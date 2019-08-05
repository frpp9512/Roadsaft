/*
SQLyog Ultimate v12.4.1 (64 bit)
MySQL - 10.1.37-MariaDB : Database - roadsaft
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`roadsaft` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `roadsaft`;

/*Table structure for table `driver` */

DROP TABLE IF EXISTS `driver`;

CREATE TABLE `driver` (
  `driver_id` int(11) NOT NULL AUTO_INCREMENT,
  `fullname` text NOT NULL,
  `position` text NOT NULL,
  `personal_id` varchar(11) DEFAULT NULL,
  `category` enum('Professional','NonProfessional') NOT NULL DEFAULT 'Professional',
  `description` text,
  `registered` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `archived` datetime DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`driver_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

/*Table structure for table `driver_license` */

DROP TABLE IF EXISTS `driver_license`;

CREATE TABLE `driver_license` (
  `driver_license_id` int(11) NOT NULL AUTO_INCREMENT,
  `dl_number` varchar(50) DEFAULT NULL,
  `dl_category` varchar(50) NOT NULL,
  `dl_createddate` datetime DEFAULT CURRENT_TIMESTAMP,
  `dl_dateofmaking` datetime NOT NULL,
  `dl_expires` datetime NOT NULL,
  `dl_description` text,
  `dl_archived` datetime DEFAULT CURRENT_TIMESTAMP,
  `dl_isactive` tinyint(1) NOT NULL,
  `driver_id` int(11) NOT NULL,
  PRIMARY KEY (`driver_license_id`),
  KEY `driver_id` (`driver_id`),
  CONSTRAINT `driver_license_ibfk_1` FOREIGN KEY (`driver_id`) REFERENCES `driver` (`driver_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

/*Table structure for table `med_exam` */

DROP TABLE IF EXISTS `med_exam`;

CREATE TABLE `med_exam` (
  `med_exam_id` int(11) NOT NULL AUTO_INCREMENT,
  `med_exam_type` enum('General','Psychological') NOT NULL DEFAULT 'General',
  `med_exam_createddate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `med_exam_dateofmaking` datetime NOT NULL,
  `med_exam_expires` datetime NOT NULL,
  `med_exam_result` enum('Able','Disable') NOT NULL DEFAULT 'Able',
  `med_exam_description` text,
  `med_exam_archived` datetime DEFAULT CURRENT_TIMESTAMP,
  `med_exam_isactive` tinyint(1) NOT NULL,
  `driver_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`med_exam_id`),
  KEY `driver_id` (`driver_id`),
  CONSTRAINT `med_exam_ibfk_1` FOREIGN KEY (`driver_id`) REFERENCES `driver` (`driver_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

/*Table structure for table `requalification` */

DROP TABLE IF EXISTS `requalification`;

CREATE TABLE `requalification` (
  `requalification_id` int(11) NOT NULL AUTO_INCREMENT,
  `req_createddate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `req_dateofmaking` datetime NOT NULL,
  `req_expires` datetime NOT NULL,
  `volume` varchar(6) NOT NULL,
  `page` varchar(6) NOT NULL,
  `req_description` text,
  `req_archived` datetime DEFAULT CURRENT_TIMESTAMP,
  `req_isactive` tinyint(1) NOT NULL DEFAULT '1',
  `driver_id` int(11) NOT NULL,
  PRIMARY KEY (`requalification_id`),
  KEY `requalification_ibfk_1` (`driver_id`),
  CONSTRAINT `requalification_ibfk_1` FOREIGN KEY (`driver_id`) REFERENCES `driver` (`driver_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

/* Function  structure for function  `DriverHasExpiredMedicalExam` */

/*!50003 DROP FUNCTION IF EXISTS `DriverHasExpiredMedicalExam` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `DriverHasExpiredMedicalExam`(driver_id int) RETURNS tinyint(1)
BEGIN
	declare expiredCount int;
	select Count(med_exam_id) into expiredCount
	from med_exam
	where med_exam.`driver_id` = driver_id
	and med_exam.`med_exam_isactive` = true
	and IsMedicalExamExpired(med_exam.`med_exam_id`);
	return expiredCount > 0;
    END */$$
DELIMITER ;

/* Function  structure for function  `GetActiveLicenseIdForDriver` */

/*!50003 DROP FUNCTION IF EXISTS `GetActiveLicenseIdForDriver` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `GetActiveLicenseIdForDriver`(driver_id int) RETURNS int(11)
BEGIN
	declare active_license_id int;
	
	select driver_license.driver_license_id into active_license_id
	from driver_license
	where driver_license.`driver_id` = driver_id
	and driver_license.dl_isactive = true
	order by driver_license.driver_license_id desc
	limit 0, 1;
	
	IF ISNULL(active_license_id)
	THEN RETURN -1;
	ELSE RETURN active_license_id; END IF;
    END */$$
DELIMITER ;

/* Function  structure for function  `GetActiveRequalificationIdForDriver` */

/*!50003 DROP FUNCTION IF EXISTS `GetActiveRequalificationIdForDriver` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `GetActiveRequalificationIdForDriver`(driver_id int) RETURNS int(11)
BEGIN
	DECLARE active_requalification_id INT;
	
	SELECT requalification_id INTO active_requalification_id
	FROM requalification
	WHERE `requalification`.driver_id = driver_id
	ORDER BY requalification.requalification_id DESC
	LIMIT 0, 1;
	
	IF ISNULL(active_requalification_id)
	THEN RETURN -1;
	ELSE RETURN active_requalification_id; END if;
    END */$$
DELIMITER ;

/* Function  structure for function  `HasDriverMedicalExamInPeriod` */

/*!50003 DROP FUNCTION IF EXISTS `HasDriverMedicalExamInPeriod` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `HasDriverMedicalExamInPeriod`(driver_id int, maximalDate date) RETURNS tinyint(1)
BEGIN
	declare med_exam_inperiod int;
	select count(med_exam_id) into med_exam_inperiod
	from med_exam
	where med_exam.`driver_id` = driver_id
	and med_exam.`med_exam_isactive` = true
	and IsMedcialExamInPeriod(med_exam_id, maximalDate);
	return med_exam_inperiod > 0;
    END */$$
DELIMITER ;

/* Function  structure for function  `IsActiveLicenseInPeriod` */

/*!50003 DROP FUNCTION IF EXISTS `IsActiveLicenseInPeriod` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsActiveLicenseInPeriod`(driver_id int, maximalDate date) RETURNS tinyint(1)
BEGIN
	declare license_id int;
	select driver_license.`driver_license_id` into license_id
	from driver_license
	where driver_license.`driver_id` = driver_id
	and driver_license.`dl_isactive` = true;
	return IsLicenseInPeriod(license_id, maximalDate);
    END */$$
DELIMITER ;

/* Function  structure for function  `IsActiveRequalificationExpired` */

/*!50003 DROP FUNCTION IF EXISTS `IsActiveRequalificationExpired` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsActiveRequalificationExpired`(driver_id int) RETURNS tinyint(1)
BEGIN
	declare requalification_id int;
	select requalification.`requalification_id` into requalification_id
	from requalification
	where requalification.`driver_id` = driver_id
	and requalification.`req_isactive` = true;
	return `IsRequalificationExpired`(requalification_id);
    END */$$
DELIMITER ;

/* Function  structure for function  `IsActiveRequalificationInPeriod` */

/*!50003 DROP FUNCTION IF EXISTS `IsActiveRequalificationInPeriod` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsActiveRequalificationInPeriod`(driver_id int, maximalDate date) RETURNS tinyint(1)
BEGIN
	declare req_id int;
	select requalification.`requalification_id` into req_id
	from requalification
	where requalification.`driver_id` = driver_id
	and requalification.`req_isactive` = true;
	return IsRequalificationInPeriod(req_id, maximalDate);
    END */$$
DELIMITER ;

/* Function  structure for function  `IsDriverActiveLicenseExpired` */

/*!50003 DROP FUNCTION IF EXISTS `IsDriverActiveLicenseExpired` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsDriverActiveLicenseExpired`(driver_id int) RETURNS tinyint(1)
BEGIN
	declare driver_license_id int;
	select `driver_license`.`driver_license_id` into driver_license_id
	from `driver_license`
	where `driver_license`.`driver_id` = driver_id
	and driver_license.`dl_isactive` = true;
	return IsLicenseExpired(driver_license_id);
    END */$$
DELIMITER ;

/* Function  structure for function  `IsLicenseExpired` */

/*!50003 DROP FUNCTION IF EXISTS `IsLicenseExpired` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsLicenseExpired`(driver_license_id int) RETURNS tinyint(1)
BEGIN
	declare licenseExpiration date;
	select driver_license.`dl_expires` into licenseExpiration
	from driver_license
	where driver_license.`driver_license_id` = driver_license_id;
	if date(licenseExpiration) < date(current_timestamp) then return true;
	else return false;
	end if;
    END */$$
DELIMITER ;

/* Function  structure for function  `IsLicenseInPeriod` */

/*!50003 DROP FUNCTION IF EXISTS `IsLicenseInPeriod` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsLicenseInPeriod`(license_id int, maximalDate date) RETURNS tinyint(1)
BEGIN
	declare expire date;
	select driver_license.`dl_expires` into expire
	from driver_license
	where driver_license.`driver_license_id` = license_id;
	return date(maximalDate) > Date(expire);
    END */$$
DELIMITER ;

/* Function  structure for function  `IsMedcialExamInPeriod` */

/*!50003 DROP FUNCTION IF EXISTS `IsMedcialExamInPeriod` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsMedcialExamInPeriod`(med_exam_id int, maximalDate date) RETURNS tinyint(1)
BEGIN
	declare expire date;
	select med_exam.`med_exam_expires` into expire
	from med_exam
	where med_exam.`med_exam_id` = med_exam_id;
	return date(maximalDate) > date(expire);
    END */$$
DELIMITER ;

/* Function  structure for function  `IsMedicalExamExpired` */

/*!50003 DROP FUNCTION IF EXISTS `IsMedicalExamExpired` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsMedicalExamExpired`(med_exam_id int) RETURNS tinyint(1)
BEGIN
	declare med_exam_expires date;
	select med_exam.`med_exam_expires` into med_exam_expires
	from med_exam
	where med_exam.`med_exam_id` = med_exam_id;
	if date(med_exam_expires) < date(current_timestamp) then return true;
	else return false;
	end if;
    END */$$
DELIMITER ;

/* Function  structure for function  `IsRequalificationExpired` */

/*!50003 DROP FUNCTION IF EXISTS `IsRequalificationExpired` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsRequalificationExpired`(requalification_id int) RETURNS tinyint(1)
BEGIN
	declare requalification_expire date;
	select requalification.`req_expires` into requalification_expire
	from requalification
	where requalification.`requalification_id` = requalification_id;
	if Date(requalification_expire) < date(current_timestamp) then return true;
	else return false;
	end if;
    END */$$
DELIMITER ;

/* Function  structure for function  `IsRequalificationInPeriod` */

/*!50003 DROP FUNCTION IF EXISTS `IsRequalificationInPeriod` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `IsRequalificationInPeriod`(requalification_id int, maximalDate date) RETURNS tinyint(1)
BEGIN
	declare expire date;
	select requalification.`req_expires` into expire
	from requalification
	where requalification.`requalification_id` = requalification_id;
	return date(maximalDate) > date(expire);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `GetActiveMedExamsForDriver` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetActiveMedExamsForDriver` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetActiveMedExamsForDriver`(in driver_id int)
BEGIN
		select * from med_exam
		where med_exam.driver_id = driver_id
		and med_exam.med_exam_isactive = true;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetDrivers` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetDrivers` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDrivers`()
BEGIN
		select * from driver
		where driver.`isActive` = true;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetDriversWithExpiredAttributes` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetDriversWithExpiredAttributes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDriversWithExpiredAttributes`()
BEGIN
		select * from driver 
		where driver.`isActive` = true 
		and (IsDriverActiveLicenseExpired(driver.`driver_id`) = true
		or IsActiveRequalificationExpired(driver.`driver_id`) = true
		or DriverHasExpiredMedicalExam(driver.`driver_id`) = true);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetDriversWithoutIssues` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetDriversWithoutIssues` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDriversWithoutIssues`(IN maximalDateForLicense DATE, IN maximalDateForRequalification DATE, IN maximalDateForMedExams DATE)
BEGIn
		SELECT * FROM driver 
		WHERE driver.`isActive` = true 
		and (IsDriverActiveLicenseExpired(driver.`driver_id`) = FALSE
		AND IsActiveRequalificationExpired(driver.`driver_id`) = FALSE
		AND DriverHasExpiredMedicalExam(driver.`driver_id`) = FALSE
		AND IsActiveLicenseInPeriod(driver.`driver_id`, maximalDateForLicense) = FALSE
		AND IsActiveRequalificationInPeriod(driver.`driver_id`, maximalDateForRequalification) = FALSE
		AND HasDriverMedicalExamInPeriod(driver.`driver_id`, maximalDateForMedExams) = FALSE);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetDriversWithWarnings` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetDriversWithWarnings` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDriversWithWarnings`(IN maximalDateForLicense DATE, IN maximalDateForRequalification DATE, IN maximalDateForMedExams DATE)
BEGIN
		select * from driver
		where driver.`isActive` = true 
		and (IsActiveLicenseInPeriod(driver.`driver_id`, maximalDateForLicense) = true
		or IsActiveRequalificationInPeriod(driver.`driver_id`, maximalDateForRequalification) = true
		or HasDriverMedicalExamInPeriod(driver.`driver_id`, maximalDateForMedExams) = true);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetInactiveDrivers` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetInactiveDrivers` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInactiveDrivers`()
BEGIN
		select * from driver
		where driver.`isActive` = false;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetLicensesHistoryForDriver` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetLicensesHistoryForDriver` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLicensesHistoryForDriver`(IN driver_id int)
BEGIN
		select * from driver_license
		where driver_license.driver_id = driver_id
		and driver_license.dl_isactive = false;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetMedicalExamsHistoryForDriver` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetMedicalExamsHistoryForDriver` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetMedicalExamsHistoryForDriver`(in driver_id int)
BEGIN
		select * from med_exam
		where med_exam.`driver_id` = driver_id
		and med_exam.`med_exam_isactive` = false;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `GetRequalificationsHistoryForDriver` */

/*!50003 DROP PROCEDURE IF EXISTS  `GetRequalificationsHistoryForDriver` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRequalificationsHistoryForDriver`(in driver_id int)
BEGIN
		SELECT * FROM requalification
		WHERE requalification.`driver_id` = driver_id
		AND requalification.`req_isactive` = FALSE;
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
