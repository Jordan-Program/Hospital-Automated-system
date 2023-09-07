/*
Navicat MySQL Data Transfer

Source Server         : cmh
Source Server Version : 50021
Source Host           : localhost:3306
Source Database       : db_its

Target Server Type    : MYSQL
Target Server Version : 50021
File Encoding         : 65001

Date: 2016-09-21 22:52:16
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tbl_accounts`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_accounts`;
CREATE TABLE `tbl_accounts` (
  `usercount` int(11) NOT NULL auto_increment,
  `userid` varchar(20) NOT NULL,
  `accountposition` varchar(20) default NULL,
  `username` varchar(20) default NULL,
  `password` varchar(20) default NULL,
  `surname` varchar(20) default NULL,
  `firstname` varchar(20) default NULL,
  `middlename` varchar(20) default NULL,
  `contactnumber` varchar(20) default NULL,
  `address` varchar(20) default NULL,
  `accountstat` varchar(255) default NULL,
  `attempts` varchar(20) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`usercount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_accounts
-- ----------------------------
INSERT INTO `tbl_accounts` VALUES ('1', 'ADN - 1', 'Admin', 'admin', 'admin', 'Menes', 'Melchisedeck', 'Urbina', '09095213367', 'Aida', 'Active', '0', null, null);
INSERT INTO `tbl_accounts` VALUES ('2', 'DOC - 2', 'Doctor', 'cruz', 'pass', 'Cruz', 'Ritche', '', '090 952-13367', 'Aida', 'Active', '0', '03:03:31 PM', 'August 15, 2016');
INSERT INTO `tbl_accounts` VALUES ('3', 'MED - 3', 'Medtech', 'Mangisme', 'pass', 'Datuin', 'Melchise', 'Urbina', '090 952-13367', 'cainta', 'Active', '0', '01:07:32 AM', 'August 27, 2016');
INSERT INTO `tbl_accounts` VALUES ('4', 'DOC - 4', 'Doctor', 'jeciel', 'pass', 'Jeciel', 'Julie Ann', '', '091 629-79329', 'cainta,rizal', 'Active', '0', '12:38:58 AM', 'September 13, 2016');
INSERT INTO `tbl_accounts` VALUES ('8', 'NUR - 5', 'Nurse', 'celine', 'pass', 'Voloso', 'Celina', '', '090 951-33686', 'Marick', 'Active', '0', '02:09:01 AM', 'September 13, 2016');
INSERT INTO `tbl_accounts` VALUES ('9', 'CAR - 6', 'Cashier', 'syyap', 'pass', 'Syyap', 'Jere', '', '090 952-13367', 'Don Mariano', 'Active', '0', '02:09:35 AM', 'September 13, 2016');
INSERT INTO `tbl_accounts` VALUES ('10', 'DOC - 7', 'Doctor', 'perez', 'pass', 'Perez', null, null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('11', 'DOC - 8', 'Doctor', 'oriina', 'pass', 'Oriina', 'Jaimee Rose', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('12', 'DOC - 9', 'Doctor', 'santiago', 'pass', 'Santiago', 'Ernerto', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('13', 'DOC - 10', 'Doctor', 'gongora', 'pass', 'Gongora', 'Charitel', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('14', 'DOC - 11', 'Doctor', 'mendoza', 'pass', 'Mendoza', 'Flida', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('15', 'DOC - 12', 'Doctor', 'siodina', 'pass', 'Siodina', 'Leah', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('16', 'DOC - 13', 'Doctor', 'paragas', 'pass', 'Paragas', 'Rocco', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('17', 'DOC - 14', 'Doctor', 'culangen', 'pass', 'Culangen', 'Erwin', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('18', 'DOC - 15', 'Doctor', 'nieto', 'pass', 'Nieto', 'Jet', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('19', 'DOC - 16', 'Doctor', 'recido', 'pass', 'Recido', 'Noel', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('20', 'DOC - 17', 'Doctor', 'madrid', 'pass', 'Madrid', 'Temujin', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('21', 'DOC - 18', 'Doctor', 'trinidad', 'pass', 'Trinidad', 'Angel', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('22', 'DOC - 20', 'Doctor', 'jarin', 'pass', 'Jarin', 'Peter', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('23', 'DOC - 21', 'Doctor', 'pena', 'pass', 'Pena', 'Christoper', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('24', 'DOC - 22', 'Doctor', 'medina', 'pass', 'Medina', 'Jayson', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('25', 'DOC - 23', 'Doctor', 'tolentino', 'pass', 'Tolentino', 'Monechelle', null, null, null, 'Active', '0', '12:58:00 AM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('26', 'MED - 24', 'Medtech', 'jordan', 'jordan', 'Jordan', 'Michael', 'Curry', '091 690-59837', 'pasig city', 'Active', '2', '06:47:50 PM', 'September 17, 2016');
INSERT INTO `tbl_accounts` VALUES ('29', 'NUR - 25', 'Nurse', 'chichi', 'pass', 'Datuin', 'Melchi', 'Urbina', '090 952-13367', 'cainta', 'Active', '0', '11:35:54 PM', 'September 19, 2016');

-- ----------------------------
-- Table structure for `tbl_admission`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_admission`;
CREATE TABLE `tbl_admission` (
  `admittedcount` int(11) NOT NULL auto_increment,
  `admittedid` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `contactpatient` varchar(255) default NULL,
  `dateadmitted` varchar(255) default NULL,
  `occupation` varchar(255) default NULL,
  `religion` varchar(255) default NULL,
  `businessaddress` varchar(255) default NULL,
  `contactbusiness` varchar(255) default NULL,
  `ward` varchar(255) default NULL,
  `roomno` varchar(255) default NULL,
  `roomrate` varchar(255) default NULL,
  `timeadmitted` varchar(255) default NULL,
  `companion` varchar(255) default NULL,
  `relation` varchar(255) default NULL,
  `companionaddress` varchar(255) default NULL,
  `contactcompanion` varchar(255) default NULL,
  `responsibleforaccounts` varchar(255) default NULL,
  `responsiblerelation` varchar(255) default NULL,
  `responsibleteladdress` varchar(255) default NULL,
  `remarks` varchar(255) default NULL,
  `mannerofentering` varchar(255) default NULL,
  `conditiononadmission` varchar(255) default NULL,
  `service` varchar(255) default NULL,
  `sssno` varchar(255) default NULL,
  `gsisnumber` varchar(255) default NULL,
  `philhealth` varchar(255) default NULL,
  `admittedofficer` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`admittedcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_admission
-- ----------------------------
INSERT INTO `tbl_admission` VALUES ('1', 'ADM - 1', null, 'LeBron', 'James', 'Harden', '1990-08-29', '26', 'Male', 'los angeles quezon city', '091 239-17239', '2016-08-29', 'Encoder', 'Iglesia ni batman', 'clippers blk4', '091 238-71283', 'Surgical', '1', '50', '02:11:09 AM', 'Steve', 'Friend', 'cainta,rizal', '091 239-12738', 'Paulo', 'Cousin', 'taytay,rizal', 'stress', '', '', '', '1111', '2222', '3333', 'menes', null);
INSERT INTO `tbl_admission` VALUES ('33', 'ADM - 2', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '1996-09-15', '20', 'Male', '173 Aida St. Marick Sub Cainta Rizal', '090 952-13367', '2016-09-17', 'PBA Player', 'Catholic ', 'kalentong st. mandaluyong city', '090 912-34854', 'Medical Male Ward', '1', '50', '12:03:35 PM', 'Japeth', 'Friend', 'Hardle St. Green Park Village Pasgi City', '090 689-92789', 'Norman Santos', 'Father', '173 Aida St. Marick Sub. Cainta, Rizal', 'drink water every day.', 'Walking', 'Fair', 'Medicine', '', '', '03-1011110-030', 'Celine', null);
INSERT INTO `tbl_admission` VALUES ('34', 'ADM - 3', '9172016 - 2', 'De leon ', 'Chadwick ', 'Urbina', '1999-04-27', '17', 'Male', '176 flora st. Marick Sub. Cainta Rizal', '090 952-13367', '2016-09-17', 'Police', 'Chrisitan', 'N/A', '091 661-93417', 'Medical Male Ward', '2', '50', '12:23:17 PM', 'Mark', 'Cousin', '#19 Jasmin St. Palmera III Antipolo City', '090 987-64579', 'Melchi Urbina', 'Brother', '656-94-74', 'kumain ng protine.', 'Walking', 'Fair', 'Medicine', '', '', '', 'Celine', null);
INSERT INTO `tbl_admission` VALUES ('35', 'ADM - 4', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '2016-09-17', '21', 'Male', 'Riverside Cainta,Rizal', '091 655-53055', '2016-09-17', 'Designer', 'Roman cathiolic', 'cainta rizal', '091 518-11527', 'Medical Male Ward', '1', '50', '07:03:45 PM', 'Melchi datuin', 'Bff', 'cainta rizal', '099 581-56433', 'Melchi datuin', 'Bff', 'cainta rizal', 'asthma', 'From Er', 'Strong', 'OB - Gyne', '', '', '12345678912345', 'Saisano', null);
INSERT INTO `tbl_admission` VALUES ('36', 'ADM - 5', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '1960-09-20', '56', 'Male', 'Cainta, Rizal', '099 581-56433', '2016-09-20', 'Professor', 'Christian', '173 aida st', '090 952-13367', 'Medical Male Ward', '1', '50', '07:47:55 PM', 'Norman', 'Father', '173 aida st', '090 952-13367', 'Norman', 'Father', '09095213367', 'sic', 'Walking', 'Strong', 'Surgey', '', '', '00000000000000', 'Sayson', null);
INSERT INTO `tbl_admission` VALUES ('37', 'ADM - 6', '9172016 - 3', 'Decastro ', 'Lara ', 'Urbina', '1999-09-17', '17', 'Female', 'Esla dahodine', '090 952-13367', '2016-09-20', '', 'A', 'N/A', '090 952-13367', 'Medical Male Ward', '1', '50', '01:11:18 AM', 'A', 'A', 'a', '000 000-00000', 'A', 'A', 'a', 'a', 'Walking', 'Strong', 'OB - Gyne', '', '', '', 'A', null);
INSERT INTO `tbl_admission` VALUES ('38', 'ADM - 7', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '2016-09-17', '21', 'Male', 'Riverside Cainta,Rizal', '091 655-53055', '2016-09-20', 'Designer', 'A', 'N/A', '090 952-13367', 'Medical Male Ward', '2', '50', '01:31:17 AM', 'A', 'A', 'a', '000 000-00000', 'A', 'A', 'a', 'a', 'From Er', 'Strong', 'OB - Gyne', '', '', '00000000000000', 'Sayson', 'Dr. Menes');

-- ----------------------------
-- Table structure for `tbl_ancillaryprice`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ancillaryprice`;
CREATE TABLE `tbl_ancillaryprice` (
  `labprice` int(255) default NULL,
  `xrayprice` int(255) default NULL,
  `ctscanprice` int(255) default NULL,
  `ecgprice` int(255) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ancillaryprice
-- ----------------------------
INSERT INTO `tbl_ancillaryprice` VALUES ('600', '600', '600', '600');

-- ----------------------------
-- Table structure for `tbl_ancillary_transaction`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ancillary_transaction`;
CREATE TABLE `tbl_ancillary_transaction` (
  `transactioncount` int(11) NOT NULL auto_increment,
  `transactionid` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `total` int(255) default NULL,
  `discount` varchar(255) default NULL,
  `amount` varchar(255) default NULL,
  `changed` varchar(255) default NULL,
  `username` varchar(255) default NULL,
  `billingstatus` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`transactioncount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ancillary_transaction
-- ----------------------------
INSERT INTO `tbl_ancillary_transaction` VALUES ('1', '09172016094026', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '1300', '0', '1300', '0', 'Menes', '', '09:40:26 AM', '2016-09-17');
INSERT INTO `tbl_ancillary_transaction` VALUES ('2', '09172016112050', '9172016 - 3', 'De leon', 'Chadwick', 'Urbina', '1200', '0', '1200', '0', 'Menes', '', '11:20:50 AM', '2016-09-17');
INSERT INTO `tbl_ancillary_transaction` VALUES ('3', '09172016120045', '9172016 - 4', 'Decastro', 'Lara', 'Urbina', '1100', '0', '2000', '900', 'Menes', '', '12:00:45 PM', '2016-09-17');

-- ----------------------------
-- Table structure for `tbl_audittrail`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_audittrail`;
CREATE TABLE `tbl_audittrail` (
  `logno` int(11) NOT NULL auto_increment,
  `user` varchar(255) default NULL,
  `action` varchar(255) default NULL,
  `message` varchar(255) default NULL,
  `datetime` varchar(255) default NULL,
  PRIMARY KEY  (`logno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_audittrail
-- ----------------------------
INSERT INTO `tbl_audittrail` VALUES ('1', 'System', 'System Start', ' System Start... ', '2016-09-17 09:19:36 AM');
INSERT INTO `tbl_audittrail` VALUES ('2', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:19:40 AM');
INSERT INTO `tbl_audittrail` VALUES ('3', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Result Module ', '2016-09-17 09:19:41 AM');
INSERT INTO `tbl_audittrail` VALUES ('4', 'System', 'System Start', ' System Start... ', '2016-09-17 09:22:07 AM');
INSERT INTO `tbl_audittrail` VALUES ('5', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:22:10 AM');
INSERT INTO `tbl_audittrail` VALUES ('6', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 09:22:11 AM');
INSERT INTO `tbl_audittrail` VALUES ('7', 'System', 'System Start', ' System Start... ', '2016-09-17 09:22:31 AM');
INSERT INTO `tbl_audittrail` VALUES ('8', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:22:35 AM');
INSERT INTO `tbl_audittrail` VALUES ('9', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 09:22:36 AM');
INSERT INTO `tbl_audittrail` VALUES ('10', 'System', 'System Start', ' System Start... ', '2016-09-17 09:22:52 AM');
INSERT INTO `tbl_audittrail` VALUES ('11', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:22:57 AM');
INSERT INTO `tbl_audittrail` VALUES ('12', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register old patient module ', '2016-09-17 09:22:57 AM');
INSERT INTO `tbl_audittrail` VALUES ('13', 'System', 'System Start', ' System Start... ', '2016-09-17 09:27:30 AM');
INSERT INTO `tbl_audittrail` VALUES ('14', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:27:35 AM');
INSERT INTO `tbl_audittrail` VALUES ('15', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register old patient module ', '2016-09-17 09:27:36 AM');
INSERT INTO `tbl_audittrail` VALUES ('16', 'System', 'System Start', ' System Start... ', '2016-09-17 09:27:50 AM');
INSERT INTO `tbl_audittrail` VALUES ('17', '', 'Login Succes', 'User Close the system ', '2016-09-17 09:27:50 AM');
INSERT INTO `tbl_audittrail` VALUES ('18', 'System', 'System Start', ' System Start... ', '2016-09-17 09:28:37 AM');
INSERT INTO `tbl_audittrail` VALUES ('19', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:28:42 AM');
INSERT INTO `tbl_audittrail` VALUES ('20', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register old patient module ', '2016-09-17 09:28:43 AM');
INSERT INTO `tbl_audittrail` VALUES ('21', 'ADN - 1', 'Click a button', 'User ADN - 1 Examine old Patient ', 'September 17, 2016 09:29:22 AM');
INSERT INTO `tbl_audittrail` VALUES ('22', 'System', 'System Start', ' System Start... ', '2016-09-17 09:30:50 AM');
INSERT INTO `tbl_audittrail` VALUES ('23', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:30:54 AM');
INSERT INTO `tbl_audittrail` VALUES ('24', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:30:55 AM');
INSERT INTO `tbl_audittrail` VALUES ('25', 'System', 'System Start', ' System Start... ', '2016-09-17 09:36:53 AM');
INSERT INTO `tbl_audittrail` VALUES ('26', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:36:58 AM');
INSERT INTO `tbl_audittrail` VALUES ('27', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:36:59 AM');
INSERT INTO `tbl_audittrail` VALUES ('28', 'System', 'System Start', ' System Start... ', '2016-09-17 09:38:21 AM');
INSERT INTO `tbl_audittrail` VALUES ('29', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:38:24 AM');
INSERT INTO `tbl_audittrail` VALUES ('30', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:38:25 AM');
INSERT INTO `tbl_audittrail` VALUES ('31', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 09:38:28');
INSERT INTO `tbl_audittrail` VALUES ('32', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:38:46 AM');
INSERT INTO `tbl_audittrail` VALUES ('33', 'ADN - 1', 'Click a button', 'User ADN - 1 Save a patient new Clinical record ', '2016-09-17 09:38:47');
INSERT INTO `tbl_audittrail` VALUES ('34', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 09:38:47');
INSERT INTO `tbl_audittrail` VALUES ('35', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillary Billin Module ', '2016-09-17 09:39:59 AM');
INSERT INTO `tbl_audittrail` VALUES ('36', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '2016-09-17 09:40:26 AM');
INSERT INTO `tbl_audittrail` VALUES ('37', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 09:40:26 AM');
INSERT INTO `tbl_audittrail` VALUES ('38', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 09:40:54 AM');
INSERT INTO `tbl_audittrail` VALUES ('39', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a Hematogy result ', '2016-09-17 09:40:57');
INSERT INTO `tbl_audittrail` VALUES ('40', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 09:40:57');
INSERT INTO `tbl_audittrail` VALUES ('41', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 09:41:53 AM');
INSERT INTO `tbl_audittrail` VALUES ('42', 'System', 'System Start', ' System Start... ', '2016-09-17 09:42:03 AM');
INSERT INTO `tbl_audittrail` VALUES ('43', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:42:08 AM');
INSERT INTO `tbl_audittrail` VALUES ('44', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:42:09 AM');
INSERT INTO `tbl_audittrail` VALUES ('45', 'System', 'System Start', ' System Start... ', '2016-09-17 09:43:21 AM');
INSERT INTO `tbl_audittrail` VALUES ('46', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:43:28 AM');
INSERT INTO `tbl_audittrail` VALUES ('47', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:43:29 AM');
INSERT INTO `tbl_audittrail` VALUES ('48', 'System', 'System Start', ' System Start... ', '2016-09-17 09:43:49 AM');
INSERT INTO `tbl_audittrail` VALUES ('49', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:43:54 AM');
INSERT INTO `tbl_audittrail` VALUES ('50', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 09:43:54 AM');
INSERT INTO `tbl_audittrail` VALUES ('51', 'System', 'System Start', ' System Start... ', '2016-09-17 09:53:15 AM');
INSERT INTO `tbl_audittrail` VALUES ('52', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 09:53:18 AM');
INSERT INTO `tbl_audittrail` VALUES ('53', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Result Module ', '2016-09-17 09:53:19 AM');
INSERT INTO `tbl_audittrail` VALUES ('54', 'ADN - 1', 'Click a button', 'User ADN - 1 Print a CT scan Result ', '2016-09-17 09:53:24');
INSERT INTO `tbl_audittrail` VALUES ('55', '', 'Click a button', 'User  Print a CT scan Result ', '2016-09-17 09:55:30');
INSERT INTO `tbl_audittrail` VALUES ('56', '', 'Click a button', 'User  Print a CT scan Result ', '2016-09-17 09:59:28');
INSERT INTO `tbl_audittrail` VALUES ('57', '', 'Click a button', 'User  Print a Clinical Record Result ', '2016-09-17 10:04:39');
INSERT INTO `tbl_audittrail` VALUES ('58', '', 'Click a button', 'User  Go Back to Main Menu  ', '2016-09-17 10:04:39');
INSERT INTO `tbl_audittrail` VALUES ('59', '', 'Click a button', 'User  will now log out ', '2016-09-17 10:05:02 AM');
INSERT INTO `tbl_audittrail` VALUES ('60', 'System', 'System Start', ' System Start... ', '2016-09-17 10:05:06 AM');
INSERT INTO `tbl_audittrail` VALUES ('61', '', 'Login Succes', 'User Close the system ', '2016-09-17 10:05:06 AM');
INSERT INTO `tbl_audittrail` VALUES ('62', 'System', 'System Start', ' System Start... ', '2016-09-17 10:22:04 AM');
INSERT INTO `tbl_audittrail` VALUES ('63', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:22:08 AM');
INSERT INTO `tbl_audittrail` VALUES ('64', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillart Transaction Report Module ', '2016-09-17 10:22:09 AM');
INSERT INTO `tbl_audittrail` VALUES ('65', 'ADN - 1', 'Click a button', 'User ADN - 1 View All transactoin ', '2016-09-17 10:22:42');
INSERT INTO `tbl_audittrail` VALUES ('66', 'ADN - 1', 'Click a button', 'User ADN - 1 View All transactoin ', '2016-09-17 10:22:42');
INSERT INTO `tbl_audittrail` VALUES ('67', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 10:22:42');
INSERT INTO `tbl_audittrail` VALUES ('68', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 10:22:58 AM');
INSERT INTO `tbl_audittrail` VALUES ('69', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 10:23:21 AM');
INSERT INTO `tbl_audittrail` VALUES ('70', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 10:23:22');
INSERT INTO `tbl_audittrail` VALUES ('71', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to File Maintenance Module ', '2016-09-17 10:23:30 AM');
INSERT INTO `tbl_audittrail` VALUES ('72', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 10:23:35 AM');
INSERT INTO `tbl_audittrail` VALUES ('73', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 10:23:37');
INSERT INTO `tbl_audittrail` VALUES ('74', 'ADN - 1', 'Click a button', 'User ADN - 1 will now log out ', '2016-09-17 10:23:43 AM');
INSERT INTO `tbl_audittrail` VALUES ('75', 'System', 'System Start', ' System Start... ', '2016-09-17 10:23:51 AM');
INSERT INTO `tbl_audittrail` VALUES ('76', '', 'Login Succes', 'User Close the system ', '2016-09-17 10:23:51 AM');
INSERT INTO `tbl_audittrail` VALUES ('77', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Emergency Room Module ', '2016-09-17 10:22:55 AM');
INSERT INTO `tbl_audittrail` VALUES ('78', 'System', 'System Start', ' System Start... ', '2016-09-17 10:34:50 AM');
INSERT INTO `tbl_audittrail` VALUES ('79', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:34:55 AM');
INSERT INTO `tbl_audittrail` VALUES ('80', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 10:34:56 AM');
INSERT INTO `tbl_audittrail` VALUES ('81', 'System', 'System Start', ' System Start... ', '2016-09-17 10:35:40 AM');
INSERT INTO `tbl_audittrail` VALUES ('82', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:35:44 AM');
INSERT INTO `tbl_audittrail` VALUES ('83', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 10:35:45 AM');
INSERT INTO `tbl_audittrail` VALUES ('84', 'ADN - 1', 'Click a button', 'User ADN - 1 insert new Patient ', '2016-09-17 10:35:52 AM');
INSERT INTO `tbl_audittrail` VALUES ('85', 'ADN - 1', 'Click a button', 'User ADN - 1 Go back to Main menu ', '2016-09-17 10:35:52 AM');
INSERT INTO `tbl_audittrail` VALUES ('86', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 10:38:38 AM');
INSERT INTO `tbl_audittrail` VALUES ('87', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 10:38:43');
INSERT INTO `tbl_audittrail` VALUES ('88', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to View patient module ', '2016-09-17 10:38:45 AM');
INSERT INTO `tbl_audittrail` VALUES ('89', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 10:38:50');
INSERT INTO `tbl_audittrail` VALUES ('90', 'System', 'System Start', ' System Start... ', '2016-09-17 10:43:31 AM');
INSERT INTO `tbl_audittrail` VALUES ('91', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:43:36 AM');
INSERT INTO `tbl_audittrail` VALUES ('92', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 10:43:36 AM');
INSERT INTO `tbl_audittrail` VALUES ('93', 'System', 'System Start', ' System Start... ', '2016-09-17 10:48:17 AM');
INSERT INTO `tbl_audittrail` VALUES ('94', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:48:21 AM');
INSERT INTO `tbl_audittrail` VALUES ('95', 'System', 'System Start', ' System Start... ', '2016-09-17 10:48:41 AM');
INSERT INTO `tbl_audittrail` VALUES ('96', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:48:45 AM');
INSERT INTO `tbl_audittrail` VALUES ('97', 'System', 'System Start', ' System Start... ', '2016-09-17 10:51:10 AM');
INSERT INTO `tbl_audittrail` VALUES ('98', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:51:45 AM');
INSERT INTO `tbl_audittrail` VALUES ('99', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 10:51:46 AM');
INSERT INTO `tbl_audittrail` VALUES ('100', 'System', 'System Start', ' System Start... ', '2016-09-17 10:53:12 AM');
INSERT INTO `tbl_audittrail` VALUES ('101', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 10:53:22 AM');
INSERT INTO `tbl_audittrail` VALUES ('102', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 10:53:23 AM');
INSERT INTO `tbl_audittrail` VALUES ('103', 'System', 'System Start', ' System Start... ', '2016-09-17 11:00:23 AM');
INSERT INTO `tbl_audittrail` VALUES ('104', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 11:00:27 AM');
INSERT INTO `tbl_audittrail` VALUES ('105', 'System', 'System Start', ' System Start... ', '2016-09-17 11:01:06 AM');
INSERT INTO `tbl_audittrail` VALUES ('106', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 11:01:14 AM');
INSERT INTO `tbl_audittrail` VALUES ('107', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 11:01:15 AM');
INSERT INTO `tbl_audittrail` VALUES ('108', 'ADN - 1', 'Click a button', 'User ADN - 1 insert new Patient ', '2016-09-17 11:01:19 AM');
INSERT INTO `tbl_audittrail` VALUES ('109', 'ADN - 1', 'Click a button', 'User ADN - 1 Go back to Main menu ', '2016-09-17 11:01:19 AM');
INSERT INTO `tbl_audittrail` VALUES ('110', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 11:03:10 AM');
INSERT INTO `tbl_audittrail` VALUES ('111', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 11:03:11');
INSERT INTO `tbl_audittrail` VALUES ('112', 'System', 'System Start', ' System Start... ', '2016-09-17 11:18:14 AM');
INSERT INTO `tbl_audittrail` VALUES ('113', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 11:18:18 AM');
INSERT INTO `tbl_audittrail` VALUES ('114', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 11:18:19 AM');
INSERT INTO `tbl_audittrail` VALUES ('115', 'ADN - 1', 'Click a button', 'User ADN - 1 Save a patient new Clinical record ', '2016-09-17 11:18:23');
INSERT INTO `tbl_audittrail` VALUES ('116', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 11:18:23');
INSERT INTO `tbl_audittrail` VALUES ('117', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 11:19:56 AM');
INSERT INTO `tbl_audittrail` VALUES ('118', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 11:20:00');
INSERT INTO `tbl_audittrail` VALUES ('119', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillary Billin Module ', '2016-09-17 11:20:01 AM');
INSERT INTO `tbl_audittrail` VALUES ('120', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '2016-09-17 11:20:50 AM');
INSERT INTO `tbl_audittrail` VALUES ('121', 'System', 'System Start', ' System Start... ', '2016-09-17 11:24:00 AM');
INSERT INTO `tbl_audittrail` VALUES ('122', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 11:24:04 AM');
INSERT INTO `tbl_audittrail` VALUES ('123', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 11:24:05 AM');
INSERT INTO `tbl_audittrail` VALUES ('124', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a Hematogy result ', '2016-09-17 11:24:09');
INSERT INTO `tbl_audittrail` VALUES ('125', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 11:24:09');
INSERT INTO `tbl_audittrail` VALUES ('126', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Result Module ', '2016-09-17 11:25:00 AM');
INSERT INTO `tbl_audittrail` VALUES ('127', 'System', 'System Start', ' System Start... ', '2016-09-17 11:56:30 AM');
INSERT INTO `tbl_audittrail` VALUES ('128', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 11:56:44 AM');
INSERT INTO `tbl_audittrail` VALUES ('129', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 11:56:45 AM');
INSERT INTO `tbl_audittrail` VALUES ('130', 'ADN - 1', 'Click a button', 'User ADN - 1 Save a patient new Clinical record ', '2016-09-17 11:56:52');
INSERT INTO `tbl_audittrail` VALUES ('131', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 11:56:52');
INSERT INTO `tbl_audittrail` VALUES ('132', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillary Billin Module ', '2016-09-17 12:00:08 PM');
INSERT INTO `tbl_audittrail` VALUES ('133', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '2016-09-17 12:00:45 PM');
INSERT INTO `tbl_audittrail` VALUES ('134', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:00:45 PM');
INSERT INTO `tbl_audittrail` VALUES ('135', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 12:01:01 PM');
INSERT INTO `tbl_audittrail` VALUES ('136', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:01:05');
INSERT INTO `tbl_audittrail` VALUES ('137', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 12:01:06 PM');
INSERT INTO `tbl_audittrail` VALUES ('138', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:01:14');
INSERT INTO `tbl_audittrail` VALUES ('139', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 12:01:18 PM');
INSERT INTO `tbl_audittrail` VALUES ('140', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a Urinalysis result ', '2016-09-17 12:01:23');
INSERT INTO `tbl_audittrail` VALUES ('141', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:01:23');
INSERT INTO `tbl_audittrail` VALUES ('142', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 12:03:30 PM');
INSERT INTO `tbl_audittrail` VALUES ('143', 'ADN - 1', 'Click a button', 'User ADN - 1 Admit a patient ', '2016-09-17 12:03:35');
INSERT INTO `tbl_audittrail` VALUES ('144', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:03:35');
INSERT INTO `tbl_audittrail` VALUES ('145', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 12:09:25 PM');
INSERT INTO `tbl_audittrail` VALUES ('146', 'ADN - 1', 'Click a button', 'User ADN - 1 Add Medical record to Medical Male Ward ', '2016-09-17 12:09:48 PM');
INSERT INTO `tbl_audittrail` VALUES ('147', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:09:48 PM');
INSERT INTO `tbl_audittrail` VALUES ('148', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 12:09:55 PM');
INSERT INTO `tbl_audittrail` VALUES ('149', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:09:57');
INSERT INTO `tbl_audittrail` VALUES ('150', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:09:59 PM');
INSERT INTO `tbl_audittrail` VALUES ('151', 'System', 'System Start', ' System Start... ', '2016-09-17 12:11:34 PM');
INSERT INTO `tbl_audittrail` VALUES ('152', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:11:40 PM');
INSERT INTO `tbl_audittrail` VALUES ('153', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:11:41 PM');
INSERT INTO `tbl_audittrail` VALUES ('154', 'System', 'System Start', ' System Start... ', '2016-09-17 12:12:40 PM');
INSERT INTO `tbl_audittrail` VALUES ('155', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:12:47 PM');
INSERT INTO `tbl_audittrail` VALUES ('156', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:12:48 PM');
INSERT INTO `tbl_audittrail` VALUES ('157', 'System', 'System Start', ' System Start... ', '2016-09-17 12:17:28 PM');
INSERT INTO `tbl_audittrail` VALUES ('158', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:17:32 PM');
INSERT INTO `tbl_audittrail` VALUES ('159', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 12:17:34 PM');
INSERT INTO `tbl_audittrail` VALUES ('160', 'System', 'System Start', ' System Start... ', '2016-09-17 12:21:53 PM');
INSERT INTO `tbl_audittrail` VALUES ('161', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:22:22 PM');
INSERT INTO `tbl_audittrail` VALUES ('162', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:22:23 PM');
INSERT INTO `tbl_audittrail` VALUES ('163', 'System', 'System Start', ' System Start... ', '2016-09-17 12:23:05 PM');
INSERT INTO `tbl_audittrail` VALUES ('164', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:23:13 PM');
INSERT INTO `tbl_audittrail` VALUES ('165', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 12:23:14 PM');
INSERT INTO `tbl_audittrail` VALUES ('166', 'System', 'System Start', ' System Start... ', '2016-09-17 12:26:58 PM');
INSERT INTO `tbl_audittrail` VALUES ('167', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:27:06 PM');
INSERT INTO `tbl_audittrail` VALUES ('168', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 12:27:07 PM');
INSERT INTO `tbl_audittrail` VALUES ('169', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:27:11');
INSERT INTO `tbl_audittrail` VALUES ('170', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:27:14 PM');
INSERT INTO `tbl_audittrail` VALUES ('171', 'System', 'System Start', ' System Start... ', '2016-09-17 12:28:07 PM');
INSERT INTO `tbl_audittrail` VALUES ('172', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:28:49 PM');
INSERT INTO `tbl_audittrail` VALUES ('173', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:28:50 PM');
INSERT INTO `tbl_audittrail` VALUES ('174', 'System', 'System Start', ' System Start... ', '2016-09-17 12:31:24 PM');
INSERT INTO `tbl_audittrail` VALUES ('175', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:31:30 PM');
INSERT INTO `tbl_audittrail` VALUES ('176', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:31:31 PM');
INSERT INTO `tbl_audittrail` VALUES ('177', 'System', 'System Start', ' System Start... ', '2016-09-17 12:32:53 PM');
INSERT INTO `tbl_audittrail` VALUES ('178', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:33:01 PM');
INSERT INTO `tbl_audittrail` VALUES ('179', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 12:33:02 PM');
INSERT INTO `tbl_audittrail` VALUES ('180', 'System', 'System Start', ' System Start... ', '2016-09-17 12:34:48 PM');
INSERT INTO `tbl_audittrail` VALUES ('181', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 12:34:51 PM');
INSERT INTO `tbl_audittrail` VALUES ('182', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 12:34:52 PM');
INSERT INTO `tbl_audittrail` VALUES ('183', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '09172016 123525');
INSERT INTO `tbl_audittrail` VALUES ('184', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '09172016 123544');
INSERT INTO `tbl_audittrail` VALUES ('185', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillart Transaction Report Module ', '2016-09-17 12:35:54 PM');
INSERT INTO `tbl_audittrail` VALUES ('186', 'ADN - 1', 'Click a button', 'User ADN - 1 View All transactoin ', '2016-09-17 12:35:57');
INSERT INTO `tbl_audittrail` VALUES ('187', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 12:35:57');
INSERT INTO `tbl_audittrail` VALUES ('188', 'ADN - 1', 'Click a button', 'User ADN - 1 will now log out ', '2016-09-17 12:36:05 PM');
INSERT INTO `tbl_audittrail` VALUES ('189', 'System', 'System Start', ' System Start... ', '2016-09-17 12:36:10 PM');
INSERT INTO `tbl_audittrail` VALUES ('190', '', 'Login Succes', 'User Close the system ', '2016-09-17 12:36:10 PM');
INSERT INTO `tbl_audittrail` VALUES ('191', 'System', 'System Start', ' System Start... ', '2016-09-17 01:44:26 PM');
INSERT INTO `tbl_audittrail` VALUES ('192', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 01:44:39 PM');
INSERT INTO `tbl_audittrail` VALUES ('193', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 01:44:39 PM');
INSERT INTO `tbl_audittrail` VALUES ('194', 'System', 'System Start', ' System Start... ', '2016-09-17 01:59:30 PM');
INSERT INTO `tbl_audittrail` VALUES ('195', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 01:59:35 PM');
INSERT INTO `tbl_audittrail` VALUES ('196', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to View patient module ', '2016-09-17 01:59:35 PM');
INSERT INTO `tbl_audittrail` VALUES ('197', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 01:59:46');
INSERT INTO `tbl_audittrail` VALUES ('198', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 02:03:49 PM');
INSERT INTO `tbl_audittrail` VALUES ('199', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:03:51');
INSERT INTO `tbl_audittrail` VALUES ('200', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 02:03:57 PM');
INSERT INTO `tbl_audittrail` VALUES ('201', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:03:59');
INSERT INTO `tbl_audittrail` VALUES ('202', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to View patient module ', '2016-09-17 02:04:00 PM');
INSERT INTO `tbl_audittrail` VALUES ('203', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:04:03');
INSERT INTO `tbl_audittrail` VALUES ('204', 'ADN - 1', 'Click a button', 'User ADN - 1 will now log out ', '2016-09-17 02:04:33 PM');
INSERT INTO `tbl_audittrail` VALUES ('205', 'System', 'System Start', ' System Start... ', '2016-09-17 02:04:37 PM');
INSERT INTO `tbl_audittrail` VALUES ('206', '', 'Login Succes', 'User Close the system ', '2016-09-17 02:04:37 PM');
INSERT INTO `tbl_audittrail` VALUES ('207', 'System', 'System Start', ' System Start... ', '2016-09-17 02:07:42 PM');
INSERT INTO `tbl_audittrail` VALUES ('208', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 02:08:05 PM');
INSERT INTO `tbl_audittrail` VALUES ('209', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register old patient module ', '2016-09-17 02:08:07 PM');
INSERT INTO `tbl_audittrail` VALUES ('210', 'System', 'System Start', ' System Start... ', '2016-09-17 02:08:35 PM');
INSERT INTO `tbl_audittrail` VALUES ('211', 'NUR - 5', 'Login Succes', 'User NUR - 5Succesfully Log in ', '2016-09-17 02:08:41 PM');
INSERT INTO `tbl_audittrail` VALUES ('212', 'NUR - 5', 'Click a button', 'User NUR - 5 will go to View patient module ', '2016-09-17 02:08:41 PM');
INSERT INTO `tbl_audittrail` VALUES ('213', 'NUR - 5', 'Click a button', 'User NUR - 5 Update a patient basic info ', '2016-09-17 02:08:45');
INSERT INTO `tbl_audittrail` VALUES ('214', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 02:08:57 PM');
INSERT INTO `tbl_audittrail` VALUES ('215', 'ADN - 1', 'Click a button', 'User ADN - 1 Go back to Main menu ', '2016-09-17 02:09:00 PM');
INSERT INTO `tbl_audittrail` VALUES ('216', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 02:09:01 PM');
INSERT INTO `tbl_audittrail` VALUES ('217', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:09:03');
INSERT INTO `tbl_audittrail` VALUES ('218', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to View patient module ', '2016-09-17 02:09:05 PM');
INSERT INTO `tbl_audittrail` VALUES ('219', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:09:07');
INSERT INTO `tbl_audittrail` VALUES ('220', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Merge new patient history to old patient history ', '2016-09-17 02:09:10 PM');
INSERT INTO `tbl_audittrail` VALUES ('221', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:09:11');
INSERT INTO `tbl_audittrail` VALUES ('222', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 02:09:14 PM');
INSERT INTO `tbl_audittrail` VALUES ('223', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:09:16');
INSERT INTO `tbl_audittrail` VALUES ('224', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Xray/Ultrasound Module ', '2016-09-17 02:09:22 PM');
INSERT INTO `tbl_audittrail` VALUES ('225', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:09:24');
INSERT INTO `tbl_audittrail` VALUES ('226', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to ECG Module ', '2016-09-17 02:09:27 PM');
INSERT INTO `tbl_audittrail` VALUES ('227', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:09:30');
INSERT INTO `tbl_audittrail` VALUES ('228', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to CTscan module ', '2016-09-17 02:09:32 PM');
INSERT INTO `tbl_audittrail` VALUES ('229', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', ' ');
INSERT INTO `tbl_audittrail` VALUES ('230', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Result Module ', '2016-09-17 02:09:39 PM');
INSERT INTO `tbl_audittrail` VALUES ('231', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu  ', '2016-09-17 02:09:41');
INSERT INTO `tbl_audittrail` VALUES ('232', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Result Module ', '2016-09-17 02:10:03 PM');
INSERT INTO `tbl_audittrail` VALUES ('233', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu  ', '2016-09-17 02:10:12');
INSERT INTO `tbl_audittrail` VALUES ('234', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillary Billin Module ', '2016-09-17 02:10:15 PM');
INSERT INTO `tbl_audittrail` VALUES ('235', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:10:21');
INSERT INTO `tbl_audittrail` VALUES ('236', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 02:10:26 PM');
INSERT INTO `tbl_audittrail` VALUES ('237', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillart Transaction Report Module ', '2016-09-17 02:10:36 PM');
INSERT INTO `tbl_audittrail` VALUES ('238', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:10:40');
INSERT INTO `tbl_audittrail` VALUES ('239', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillart Transaction Report Module ', '2016-09-17 02:10:47 PM');
INSERT INTO `tbl_audittrail` VALUES ('240', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:10:50');
INSERT INTO `tbl_audittrail` VALUES ('241', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:10:56 PM');
INSERT INTO `tbl_audittrail` VALUES ('242', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:11:03 PM');
INSERT INTO `tbl_audittrail` VALUES ('243', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:11:08 PM');
INSERT INTO `tbl_audittrail` VALUES ('244', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 02:11:12 PM');
INSERT INTO `tbl_audittrail` VALUES ('245', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:11:14');
INSERT INTO `tbl_audittrail` VALUES ('246', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 02:11:18 PM');
INSERT INTO `tbl_audittrail` VALUES ('247', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:11:20');
INSERT INTO `tbl_audittrail` VALUES ('248', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 02:11:23 PM');
INSERT INTO `tbl_audittrail` VALUES ('249', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:11:25');
INSERT INTO `tbl_audittrail` VALUES ('250', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to File Maintenance Module ', '2016-09-17 02:11:37 PM');
INSERT INTO `tbl_audittrail` VALUES ('251', 'ADN - 1', 'Click a button', 'User ADN - 1 will now log out ', '2016-09-17 02:11:58 PM');
INSERT INTO `tbl_audittrail` VALUES ('252', 'System', 'System Start', ' System Start... ', '2016-09-17 02:12:07 PM');
INSERT INTO `tbl_audittrail` VALUES ('253', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 02:12:13 PM');
INSERT INTO `tbl_audittrail` VALUES ('254', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-17 02:12:17 PM');
INSERT INTO `tbl_audittrail` VALUES ('255', 'ADN - 1', 'Click a button', 'User ADN - 1 insert new Patient ', '2016-09-17 02:12:20 PM');
INSERT INTO `tbl_audittrail` VALUES ('256', 'ADN - 1', 'Click a button', 'User ADN - 1 Go back to Main menu ', '2016-09-17 02:12:20 PM');
INSERT INTO `tbl_audittrail` VALUES ('257', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Doctor module ', '2016-09-17 02:14:38 PM');
INSERT INTO `tbl_audittrail` VALUES ('258', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 02:14:39');
INSERT INTO `tbl_audittrail` VALUES ('259', 'ADN - 1', 'Click a button', 'User ADN - 1 will now log out ', '2016-09-17 02:14:43 PM');
INSERT INTO `tbl_audittrail` VALUES ('260', 'System', 'System Start', ' System Start... ', '2016-09-17 02:16:42 PM');
INSERT INTO `tbl_audittrail` VALUES ('261', '', 'Login Succes', 'User Close the system ', '2016-09-17 02:16:42 PM');
INSERT INTO `tbl_audittrail` VALUES ('262', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Emergency View and Transfer Module ', '2016-09-17 02:11:05 PM');
INSERT INTO `tbl_audittrail` VALUES ('263', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Emergency History ', '2016-09-17 02:11:00 PM');
INSERT INTO `tbl_audittrail` VALUES ('264', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Emergency Room Module ', '2016-09-17 02:10:52 PM');
INSERT INTO `tbl_audittrail` VALUES ('265', 'System', 'System Start', ' System Start... ', '2016-09-17 06:44:49 PM');
INSERT INTO `tbl_audittrail` VALUES ('266', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-17 06:45:35 PM');
INSERT INTO `tbl_audittrail` VALUES ('267', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to File Maintenance Module ', '2016-09-17 06:45:37 PM');
INSERT INTO `tbl_audittrail` VALUES ('268', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register old patient module ', '2016-09-17 06:54:24 PM');
INSERT INTO `tbl_audittrail` VALUES ('269', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 06:56:36 PM');
INSERT INTO `tbl_audittrail` VALUES ('270', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 06:56:57 PM');
INSERT INTO `tbl_audittrail` VALUES ('271', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', 'September 17, 2016 07:00:37 PM');
INSERT INTO `tbl_audittrail` VALUES ('272', 'ADN - 1', 'Click a button', 'User ADN - 1 Transfer a patient to Admitting. ', ' ');
INSERT INTO `tbl_audittrail` VALUES ('273', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:03:17 PM');
INSERT INTO `tbl_audittrail` VALUES ('274', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 07:03:44 PM');
INSERT INTO `tbl_audittrail` VALUES ('275', 'ADN - 1', 'Click a button', 'User ADN - 1 Admit a patient ', '2016-09-17 07:03:45');
INSERT INTO `tbl_audittrail` VALUES ('276', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:03:45');
INSERT INTO `tbl_audittrail` VALUES ('277', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 07:12:51 PM');
INSERT INTO `tbl_audittrail` VALUES ('278', 'ADN - 1', 'Click a button', 'User ADN - 1 Send an additional check for patient. ', '2016-09-17 07:12:52');
INSERT INTO `tbl_audittrail` VALUES ('279', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:12:52');
INSERT INTO `tbl_audittrail` VALUES ('280', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Laboratory Module ', '2016-09-17 07:17:24 PM');
INSERT INTO `tbl_audittrail` VALUES ('281', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:17:27');
INSERT INTO `tbl_audittrail` VALUES ('282', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Xray/Ultrasound Module ', '2016-09-17 07:17:29 PM');
INSERT INTO `tbl_audittrail` VALUES ('283', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a result to Xray/Ultrasound ', '2016-09-17 07:17:32');
INSERT INTO `tbl_audittrail` VALUES ('284', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:17:32');
INSERT INTO `tbl_audittrail` VALUES ('285', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 07:17:54 PM');
INSERT INTO `tbl_audittrail` VALUES ('286', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 07:25:37 PM');
INSERT INTO `tbl_audittrail` VALUES ('287', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:25:39');
INSERT INTO `tbl_audittrail` VALUES ('288', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ancillart Transaction Report Module ', '2016-09-17 07:25:49 PM');
INSERT INTO `tbl_audittrail` VALUES ('289', 'ADN - 1', 'Click a button', 'User ADN - 1 View All transactoin ', '2016-09-17 07:27:22');
INSERT INTO `tbl_audittrail` VALUES ('290', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:27:22');
INSERT INTO `tbl_audittrail` VALUES ('291', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-17 07:27:53 PM');
INSERT INTO `tbl_audittrail` VALUES ('292', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 07:28:14 PM');
INSERT INTO `tbl_audittrail` VALUES ('293', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:28:15');
INSERT INTO `tbl_audittrail` VALUES ('294', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 07:28:43 PM');
INSERT INTO `tbl_audittrail` VALUES ('295', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:29:56');
INSERT INTO `tbl_audittrail` VALUES ('296', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-17 07:30:10 PM');
INSERT INTO `tbl_audittrail` VALUES ('297', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-17 07:30:12');
INSERT INTO `tbl_audittrail` VALUES ('298', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-17 07:31:42 PM');
INSERT INTO `tbl_audittrail` VALUES ('299', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:33:00');
INSERT INTO `tbl_audittrail` VALUES ('300', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-20 07:33:03 PM');
INSERT INTO `tbl_audittrail` VALUES ('301', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-20 07:33:33 PM');
INSERT INTO `tbl_audittrail` VALUES ('302', 'ADN - 1', 'Click a button', 'User ADN - 1 Send an additional check for patient. ', '2016-09-20 07:33:38');
INSERT INTO `tbl_audittrail` VALUES ('303', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:33:38');
INSERT INTO `tbl_audittrail` VALUES ('304', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-20 07:33:58 PM');
INSERT INTO `tbl_audittrail` VALUES ('305', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '09202016 073451');
INSERT INTO `tbl_audittrail` VALUES ('306', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-20 07:37:00 PM');
INSERT INTO `tbl_audittrail` VALUES ('307', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:37:02');
INSERT INTO `tbl_audittrail` VALUES ('308', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to register new patient module', '2016-09-20 07:37:12 PM');
INSERT INTO `tbl_audittrail` VALUES ('309', 'ADN - 1', 'Click a button', 'User ADN - 1 insert new Patient ', '2016-09-20 07:37:17 PM');
INSERT INTO `tbl_audittrail` VALUES ('310', 'ADN - 1', 'Click a button', 'User ADN - 1 Go back to Main menu ', '2016-09-20 07:37:17 PM');
INSERT INTO `tbl_audittrail` VALUES ('311', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-20 07:43:10 PM');
INSERT INTO `tbl_audittrail` VALUES ('312', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:43:13');
INSERT INTO `tbl_audittrail` VALUES ('313', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:47:26 PM');
INSERT INTO `tbl_audittrail` VALUES ('314', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-20 07:47:34 PM');
INSERT INTO `tbl_audittrail` VALUES ('315', 'ADN - 1', 'Click a button', 'User ADN - 1 Admit a patient ', '2016-09-20 07:47:55');
INSERT INTO `tbl_audittrail` VALUES ('316', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:47:55');
INSERT INTO `tbl_audittrail` VALUES ('317', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Ward Module ', '2016-09-20 07:53:06 PM');
INSERT INTO `tbl_audittrail` VALUES ('318', 'ADN - 1', 'Click a button', 'User ADN - 1 Send an additional check for patient. ', '2016-09-20 07:53:14');
INSERT INTO `tbl_audittrail` VALUES ('319', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:53:14');
INSERT INTO `tbl_audittrail` VALUES ('320', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to CTscan module ', '2016-09-20 07:53:48 PM');
INSERT INTO `tbl_audittrail` VALUES ('321', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a result in CT scan ', '2016-09-20 07:53:51');
INSERT INTO `tbl_audittrail` VALUES ('322', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', 'September 20, 2016 07:53:58 PM');
INSERT INTO `tbl_audittrail` VALUES ('323', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to ECG Module ', '2016-09-20 07:54:02 PM');
INSERT INTO `tbl_audittrail` VALUES ('324', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a result in ECG ', '2016-09-20 07:54:05');
INSERT INTO `tbl_audittrail` VALUES ('325', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:54:05');
INSERT INTO `tbl_audittrail` VALUES ('326', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Xray/Ultrasound Module ', '2016-09-20 07:54:18 PM');
INSERT INTO `tbl_audittrail` VALUES ('327', 'ADN - 1', 'Click a button', 'User ADN - 1 Add a result to Xray/Ultrasound ', '2016-09-20 07:54:20');
INSERT INTO `tbl_audittrail` VALUES ('328', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-20 07:54:20');
INSERT INTO `tbl_audittrail` VALUES ('329', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admission Billing Module ', '2016-09-20 07:54:34 PM');
INSERT INTO `tbl_audittrail` VALUES ('330', 'ADN - 1', 'Click a button', 'User ADN - 1 Perform a Billing to a Patient ', '09222016 080401');
INSERT INTO `tbl_audittrail` VALUES ('331', 'System', 'System Start', ' System Start... ', '2016-09-18 09:19:42 PM');
INSERT INTO `tbl_audittrail` VALUES ('332', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-18 09:19:54 PM');
INSERT INTO `tbl_audittrail` VALUES ('333', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', 'September 18, 2016 09:20:13 PM');
INSERT INTO `tbl_audittrail` VALUES ('334', 'System', 'System Start', ' System Start... ', '2016-09-18 09:21:49 PM');
INSERT INTO `tbl_audittrail` VALUES ('335', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-18 09:21:53 PM');
INSERT INTO `tbl_audittrail` VALUES ('336', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-18 09:21:54 PM');
INSERT INTO `tbl_audittrail` VALUES ('337', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-18 09:21:57');
INSERT INTO `tbl_audittrail` VALUES ('338', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', 'September 18, 2016 09:22:10 PM');
INSERT INTO `tbl_audittrail` VALUES ('339', 'System', 'System Start', ' System Start... ', '2016-09-18 09:23:30 PM');
INSERT INTO `tbl_audittrail` VALUES ('340', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-18 09:23:36 PM');
INSERT INTO `tbl_audittrail` VALUES ('341', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to Admitting Module ', '2016-09-18 09:23:36 PM');
INSERT INTO `tbl_audittrail` VALUES ('342', 'ADN - 1', 'Click a button', 'User ADN - 1 Go Back to Main Menu ', '2016-09-18 09:23:39');
INSERT INTO `tbl_audittrail` VALUES ('343', 'System', 'System Start', ' System Start... ', '2016-09-20 12:39:19 AM');
INSERT INTO `tbl_audittrail` VALUES ('344', 'NUR - 25', 'Login Succes', 'User NUR - 25Succesfully Log in ', '2016-09-20 12:39:25 AM');
INSERT INTO `tbl_audittrail` VALUES ('345', 'NUR - 25', 'Click a button', 'User NUR - 25 will go to Doctor module ', '2016-09-20 12:39:26 AM');
INSERT INTO `tbl_audittrail` VALUES ('346', 'NUR - 25', 'Click a button', 'User NUR - 25 Go Back to Main Menu ', '2016-09-20 12:39:47');
INSERT INTO `tbl_audittrail` VALUES ('347', 'System', 'System Start', ' System Start... ', '2016-09-20 12:40:25 AM');
INSERT INTO `tbl_audittrail` VALUES ('348', 'NUR - 25', 'Login Succes', 'User NUR - 25Succesfully Log in ', '2016-09-20 12:40:31 AM');
INSERT INTO `tbl_audittrail` VALUES ('349', 'System', 'System Start', ' System Start... ', '2016-09-20 12:40:47 AM');
INSERT INTO `tbl_audittrail` VALUES ('350', 'NUR - 25', 'Login Succes', 'User NUR - 25Succesfully Log in ', '2016-09-20 12:40:52 AM');
INSERT INTO `tbl_audittrail` VALUES ('351', 'NUR - 25', 'Click a button', 'User NUR - 25 will go to File Maintenance Module ', '2016-09-20 12:40:53 AM');
INSERT INTO `tbl_audittrail` VALUES ('352', '', 'Click a button', 'User  Admit a patient ', '2016-09-20 01:11:18');
INSERT INTO `tbl_audittrail` VALUES ('353', '', 'Click a button', 'User  Go Back to Main Menu ', '2016-09-20 01:11:18');
INSERT INTO `tbl_audittrail` VALUES ('354', '', 'Click a button', 'User  Admit a patient ', '2016-09-20 01:31:17');
INSERT INTO `tbl_audittrail` VALUES ('355', '', 'Click a button', 'User  Perform a Billing to a Patient ', '09202016 095643');
INSERT INTO `tbl_audittrail` VALUES ('356', 'System', 'System Start', ' System Start... ', '2016-09-20 11:09:07 PM');
INSERT INTO `tbl_audittrail` VALUES ('357', '', 'Login Succes', 'User Close the system ', '2016-09-20 11:09:07 PM');
INSERT INTO `tbl_audittrail` VALUES ('358', 'System', 'System Start', ' System Start... ', '2016-09-21 10:09:45 PM');
INSERT INTO `tbl_audittrail` VALUES ('359', 'ADN - 1', 'Login Succes', 'User ADN - 1Succesfully Log in ', '2016-09-21 10:10:20 PM');
INSERT INTO `tbl_audittrail` VALUES ('360', 'ADN - 1', 'Click a button', 'User ADN - 1 will go to File Maintenance Module ', '2016-09-21 10:10:21 PM');
INSERT INTO `tbl_audittrail` VALUES ('361', 'ADN - 1', 'Click a button', 'User ADN - 1 will now log out ', '2016-09-21 10:51:50 PM');
INSERT INTO `tbl_audittrail` VALUES ('362', 'System', 'System Start', ' System Start... ', '2016-09-21 10:51:53 PM');
INSERT INTO `tbl_audittrail` VALUES ('363', '', 'Login Succes', 'User Close the system ', '2016-09-21 10:51:53 PM');

-- ----------------------------
-- Table structure for `tbl_basicinfo`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_basicinfo`;
CREATE TABLE `tbl_basicinfo` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `ht` varchar(255) default NULL,
  `wt` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `occupation` varchar(255) default NULL,
  `contactnumber` varchar(255) default NULL,
  `philhealth` varchar(255) default NULL,
  `patientstatus` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  `image` longblob,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_basicinfo
-- ----------------------------
INSERT INTO `tbl_basicinfo` VALUES ('32', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '1996-09-15', '20', 'Male', '5\'7', '120', '173 Aida St. Marick Sub Cainta Rizal', 'PBA Player', '09095213367', 'With Philhealth', 'Out - Patient', '10:02:40 PM', 'September 15, 2016', 0x89504E470D0A1A0A0000000D4948445200000200000002000806000000F478D4FA0000000473424954080808087C0864880000000970485973000085B6000085B601A9B9F3CC0000001974455874536F667477617265007777772E696E6B73636170652E6F72679BEE3C1A000031F04944415478DAEDDD777CD5D5FDC7F1028AA342D5FAABB6DA3A5A6B6DFD756855ACDDED4FADD6DA5A198228842943650B88124218612343866C1551A60C995964900442980964EF89826C02FC3EA77EB511336E6EEEF7DEEFF99ED71FCFC7C347A5989CEF39E7F3BEDF7BC6372E5EBCF80D00CED5B2C3F0A6E216F133F11BF198682DBA8A0122444C150BC52A112E768A54715864886C912BF245912811E5E288382A3E13272C65D69FDF2F12ACBF6FAD5826E68B6962AC785DF4B37E8E7F8A16E2367125CF0D703E1A01086C71BF4AFC48FC513C275EB50AAC2AE449A2585C101735F3A9154022C45231D9FADD3A5801E617E21AFA00400000DC5CE4AF170F8BCE6282F848ECB63E815F349C7A1B1125DEB602C2BFC5CFC5D5F41D800000E852E86F167F15BDC50CEBD5793145DE2B17ACAF2B541BCE1603C593EAAB10FA1A4000000255E89B885F5ADF7DAB4FAE3BACEFD129DCFEA1D62F6C10A1D61B83DBE897000100B0A3E0FF403C23C659AFAB4F50841DA7426CB11627AA0592778A46F45F800000785AEC9B8B3F8BC1D642BC228AABB6D45B998FADB5050F89CBE9E3000100F8A2E05F6115FC51D696B7F3144ED73A2E368921D6A24C02010800804105BF91B8D75A54A68AC1490AA3B14E585F1BBC267EA7CE5B608C800000B8ABE8DF2EBA5807D9B0F50E35516170A3E8256E65EC800000E8B94AFF8FD6E9781914367829C53A65F101161482000038FBBBFC27AC6D7965142FD87060D11CEB2C82AB1873200000812DFACDAC2D5FEAA8D9631429F8F1AB8235D6C98E373216410000FC53F46F1041D6E534A7294608B04A6BAB617BEE36000100F07DD1BFD2FAA4BFC19A70293C70EAAE82F7C4DFD962080200D0B0C2FFA098293EA1B840336A1DCA74757D3363190400C0B3A27FB37572DB418A085C22538C147733C6410000BEFE8ABF8DF55D2A27F1C1CDE2C5F36AD70A631F0400985CF8EFB15EF17F4A6180815F11A88B8B6E672E000100A614FDC6E21F622B4500F8CF1BAF75D619168D99234000801B0BFFB7441F4EE6036A5D2B30486D7565CE0001006E28FC778969E2332678C023EA7C8B456A170C73080800D0ADE8AB1BF7FE66EDDBBFC0840E782D523CCABC0202009C5EF82FB76EDD4B63E2067C6AA7788675022000C069855F5DC4F3A2C861A2066C952A3A72D220080070C2FEFDDE229F8919F0AB5CF192B89AB9080400F8B3F05F6DADE82F62220602AA540C55BB6C989B4000809D85FF1A31509430F1028E7254BCCE8D842000C0D785BF991822CA996801472BB1BE966BCADC0502001A52F82F133DF8C40F6879A8503BB52597B90C0400D4B7F83F65AD38663205F4B55B3CCE9C0602003C29FCF75B878F307902EE3A50E821E6381000505DE1BF5DBCC7C97D80ABAD143F65CE030100AAF05F27C68B334C8E80112AC59BE25AE6400200CC3DB6B7AF38C28408187B864047160A12006056F1FFBDD8CF040840C4897B991B09007077E1BF41CCE37B7E0097382F668AEB992B090070DFF5BC1D39C807401DCAAD1B3DB9759000001714FF9F8A28263600F590201E600E250040CFC27F951825CE329901F082FAAAF02DD19C399500007D8AFFDFACA34099C400F8E2EAE147995B09007076E1FFB658CA8405C0066F73ED300100CE2CFE4F882226290036CAE76E0102009C7555EF1C2626007EB4409D22CA1C4C0040600FF4E1BB7E008150289E642E2600C0BF85FF0AEBFCFEF34C4200026C0907081100E09FE27F2FC7F8027018B5FEE8AFCCD10400D853F82F13C3D8D70FC0C1C709878A26CCD90400F8AEF8DF2AE29960006860BBF83E733701000D2FFE4FB6E4CA5E007AA9104F31871300E0FD2BFF306EEE03A0B129A229733A01009E17FF9B453493070017D8297EC4DC4E0040DDC5FF1151CAA401C0458E89B6CCF10400545FF81B8B60F6F60370B1B9EA1C13E67C0200FE5BFC6F145B991C001840ED68FA2E733F0180E2FFF971BE854C0A000C5220EEA70610004C2EFE5D38D80780A14E89F6D40202806985BF8998C4040000C3C7A93550D406028009C5BFB958CFA007802F6D10D7522308006E2EFE7770910F00542B4DDC45AD2000B875B15F39831C006AF4A9789C9A41007053F1EFC4623F00F0883A0BE5156A0701C00D87FB4C60400380578B031B514B08003A16FF6F8A750C6200F0DA3BE2726A0A0140A7E2FF6DEBB42B06300034CC66D18CDA4200D0A1F8DFC24A7F00F0A9647113358600E0E4E27F97C861B00280CF65891F536B08004E2CFEF7B5E41A5F00B093DA4ADD829A43007052F1FF73CBCFEFBB66800280BD4E88BF537B08004E28FE4F8BD30C4A00F09B4AD1811A44000864F1EF6C7544062400F8D705D1855A44000844F11FC4000480808780EED42402803F8BFF30061E0038462F6A1301C01FC57F08830D001CE7656A1401C0CEE23F904106008ED58F5A4500B0A3F8F763700180E30DA46611007C59FC5F66500180368650BB0800BE28FEBD184C70B833AD3A061F691D34A2A06DE790F4F6DD47ED0BEA357657B73E13E27B0F9ABA7DC01B6F450E1B3D2F62D4A477C227CFFA3062F6A2B5514B3EDC1CB3627DF40E45FDB3FADFD4BF537F46FD59F5FF51FF5FF577A8BF4BFD9DEAEF56FF0DF5DF52FF4DDA1D0E378C1A46006848F1EFCE2042A04F3D6BD775645ACF01936343272E097F67F9969898C47D07F71DCA2A48CF29389257527AA6A8BCE26220A8FFB6FA19D4CFA27E26F5B3C9CF18A17E56F533CBCF7E92E787001B442D23007853FCBB587B4C1944B05DEBA0E0A28E3DC7EE1A387C56E4B4B92B23D66D894FDC9B96995F585671215005BEA1D4CFAE7E87B59BE392D4EF24BF5B94FC8EC9F2BB16F3CCE1479DA9690480FA14FF0E147FD8E47450AFB0A490F18BB72DFE60D3F6ED897BF767E5177DA66B91F796FA9DB727EC3D206D1013327E5184B4C92EBE56808DC7063F4D6D23007852FCFFCEF1BEF0A5369D46E40C0A9E15BEEAE3ED3B720A4B8E9B56EC3D955D587C62D586ED89EA4D81B4591E7D07BE0CDEE2CFD43802406DC5BF45CBCF6F9A62C0A0214E767E695CC2B4B92BC393F71FCEA4B87B67D7BE43D96FCE5911256D99246D7A8A7E85065237B6DE47AD23005457FC7FDCF2F3BBA61928A8B7673B85640E0E9913BE76735C426E51C9490AB86F499B9E5AB33176E7E0117322DB740AC9A6CFC14BA5E22E6A1E01A06AF1BF4964313850BF57FB21995367AF08DF7330238722ED5FBB0FA4E74D99BD3C8A30002FE4885BA87D040055FC9B896406053C15D42B2C71F5C731F1856515E729C681DE69507E61D586ED09EAAC02FA26EA61BFF83601C0ECE27FB9D8CC608027FBF1FB0D9B199198929A4AE175A684DDA987FA0D9B11C5F903F050BCF82601C0CCE2DF48BCC320401DFBF30BC64D7B7F4B7A6E411945560FE93905E5E3A62DDDA69E1D7D187558271A1300CC0B00E3E8FCA849FBEEA376BFB7726B544169F9198AAA9E0A4ACBCEBEB7626BB43CCB14FA346A3181006056F17F854E8F1A0A7F4A547C4A3205D45DD4332508A0169D08006614FFC7C5793A3C2EF1E9CCF9ABB7159655545230DDBA60B0A2523D63F5ACE9EFB8C459F17B0280BB8BFF5D0C7E5CAA47FFC9DB5333728B28926650CF5A3D73FA3E2EA1CE81B98300E0CEE27FAD48A393E3CB7DFC4123723FDA141B4F5134937AF6AA0F301670C9F6C0E604007715FFC662039D1B96736F8C991FCEB9FC507D40F505D5271817B0AC174D0800ACF887CB3CDF7DD4DE1DC907D2287EA84AF509D5371823B04C2200B8A3F8B7A7334319396171B8BAA39E82871A16095E089DB8389CB1024B170280DEC5FF7E6E118338B368D9C6288A1C3CB1F0FD8D6A81E019C60D3B03DCBE33C0CDC5FFBB8293C00CD7AA63F091CD5149BB286CA88FCD9149C9D2773E610C19AF50DC4800D0ABF85F619DF34C0736FAB6BE1159BBF61D4EA7A0C11B3BF71ECA943E94C35832DE56B71E17ECD60030974E6BF862BF1747EF4ACFE1FC7E34CCE1ECFC72E94B7B1853C60B2600E851FCDBD259CDD673C09488BC92D2931430F8426E51C9A99E0326C730B68CA64E8F7D8400E0ECE2FF23718CCE6AAEE163177C2C93F6790A177CBD43E0F5CFCF0B609C99AB54DC4C007066F16F2A76D249CDD5F7B5199B2956B0539FA1D33942D86CD1E2320280F302C0143AA7B9827A85EDE0EA5ED82DBFA4EC5CC75E63931973460B230038ABF83F45A73457DBCE216959F945472850F0878CBCC2A3CF760EC964EC19EB82789200E08CE2FF7D5141A734769F7FC9DEB4CC2C0A13FC29E56046BEF4BD72C6A0B18E885B0900812DFE4D04DFC999EB44F48E3DBB29480884F0D8E4039C346AB478DDD703E81E0042E984E66ECBF9604D4434850881B474D5B604EB953063D24CC308008129FE7FB5F666D2090D14F6E65256FCC311C64C79379A3169F47D01F71200FC5BFCAF1745743E33B5EF362AA5B0ACBC92E2032728282D3F2F7D3295B169ACFDEAF8790280FF02C0123A9DB937FB25EC3E7880C2032789DBB93F5DFAE639C6A7B1C61300FC53FC9FA4B3996BC4F845BCFA872305872DE4AB00B38F0AFE3D01C0DEE27F9D753D231DCE40CF760A49E78C7F38F8CE8033D247B93DD05CEA6C88660400FB02C0023A99B9876F6C89DE9944A181936D0C4FD8CB5835DA1C02803DC5FF713A97B9FA0F9BB98D02031DF47D6D462C63D6684F10007C5BFCBF25F2E958C69EF65794C951BFD0447A6EC131E9B3658C5D63A91D6ADF2600F82E00BC4DA732D7D4D9CBB75058A093496F7DC009A5665B4A00F04DF17F94CE64F4A7FF8A9CC2E2631415E8242BBFE8A4F4DDA38C61A33D46006858F16F2E72E948E61A396131DBFEA0A511E316B12DD06C19E22A0280F701E02D3A91D997FD1CCEC92FA1984047A999B9EAC6B8D38C63A38D24007857FC1FE0920DB30D0A9EB59542029D0D7CE3AD18C6B2D927978A9F1000EA57FC1B8B043A8FD1CEED4DCDCCA4884067C9FB0FE7736999F1B61100EA1700BAD069CCD66BE094480A08DCA0E780C93B18D3C66B4F00F0FCA6BF723A8CD936472525523CE0061F8727EC614C1BAF441D654F00A83B00CCA4B318BFF5AF98EB7EE1A6EB82A54FF3A1066F11006A2FFEF7F27D19060E9F154EE180CB1603723010D4A2F6160480EA8B7F23114727C1E6A8A49D140DB8EA92A088C414C636C46ED18400F0F5001044E740AB8EC125BCFE874BBF06E07E00283D08005F2DFED78A523A06060E9F1541C1802BBF06183E2B8A310EABD6352700FC3700BC49A7C07F5EFF472625532CE0469B22137733C661194500F8BCF8FF5454D221A08EFE2D282D3B47B1803BBF06283BA7FA38E31CE294F83E01A0C3F0957406281D7A8EE1D33F5CAD438F312C06C41716191D00A4011EA213E00BC1610BB75124E066C3C72E8864ACA3CAB6C07B4D0E000C067C69D586ED711409B8D98A7551498C7538E59E804016FFC779F8A89A86D3730A4A291270B3B4ACDC4F18EBB8C4DF8D0A00D6A13FAC88C597DA741A9141818009A4AFE731E651C50171994901A01D0F1D55F51E3495DBFF60845E03A7703B202EF5A21101407ED1A62293078EAA464D7A6733C501261839617134631ED5DC16D8CC8400D09B878D4B2D5AB68913006184F9EF6D8867CCA31A435C1D00E417BCC64A3A3C6C7C45786C321700C1089BA392F633E6510D7565F4356E0E00AFF390519DB4CCDC7C8A034CB0EF505639631E3518E8CA0020BFD8B7C4511E30AAF1994C8CE7290E30416159B9EAF36718F7A8612DC0D56E0C004378B8A8610B603A8501866D05CC67ECA3067D5C150054A2E1BA5FD4A46D979107280A3089F4797642A12645E24A3705809778A8A849FBEEA37653146092F6DD46A532F6518BDEAE0800F28B5C2E7279A0A8F116C01E6392280A30C90B3DC6EC63ECA316EA2BA22BDC10003AF230519B4EBDC3E2290A304950EF308E4247C04F07B4BBF83716BCEA42ADBAF5991043518049BABE326127631F75C8516FD0750E00CFF01051979E03A644511460921E03262730F6E1812E3A0700522EEAF4CA9069E1140598E4E5C16FC631F6E101F506BD917601407EE8477978F0C48037DEDA46518049FA0F9B19CBD887871ED3310044F2E0E089BEAFCDE00D008CD267E8F418C63E3CB44EAB00203FF0833C3478AA7BDF89B114059844FA3C6B00E0A90BE24E9D02C0221E1A3C3E07A0E798648A024CD2A1C79814C63EEA618A1601407ED01BC4691E183CD5AE6BE8418A024C227D9EEDD1A80F75915E331D02C0201E16EA170046A651146056001899C6D847A08F07B6E3E01F2EB90001002000C0B7D27CBD25D0D701E0091E120800000100CEDF12E8EB00B08E070402004000802DD63B3200C80F76BB38CF030201002000C0B62D813F76620018CBC30101002000C056931C1500E407BA4294F1604000000800B05599AF6E09F45500789E870202004000805F3CEDA40010CF030101002000C02FD6382200C80F72370F030400800000BF39276E74420018C9C30001002000C0AFFA39210070F21F0800000100FEB52FA001407E80DFF010400000080008885F0732004CE70180000010001010D3031200D43E44F6FE8300001000103047D4393C8108007FA7F1410000080008A856810800EFD1F02000000400E8794190B7C5FF1A718286070100200020A02AC50DFE0C00ED697410000002001C21C89F01E0631A1C04008000004758EB9700A08E1FB45E39D0E8200000040004DE69D1CC1F01A0338D0D0200400080A3B4F647005843438300001000E0284B6D0D00F21FB84A9CA4A14100000800709463F53D14A8BE01E0491A190400800000477AC2CE003087060601002000C091DEB62500C85FDC4814D1C020000004003892BA9FA7891D01E0011A17040080000047FBA31D012084860501002000C0D1A6DA110052685810000002001C2DC3A70140FEC25B69541000000200B470BB2F03402F1A1404008000002D74F16500D848838200001000A085653E0900F21735E5F43F1000000200B451AEB6EEFB2200FC8EC60401002000402BF7FA2200BC46438200001000A09581BE08005B68481000000200B4B2A9410140FE82CBC5091A120400800000ADA8B57B573424003C4C238200001000A0A53F3724000CA1014100000800D0D2A88604804D342008000001005A4AF02A0058DFFF1FA7014100000800D0D279D1CC9B00F0108D0702004000803BD701D416005EA5E14000000800D0DAABDE04808F69381000000200B4B6A25E01409D212C8ED2702000000400682DBFBE01E04E1A0D040080000057F85E7D02406B1A0C040080000057F8677D02C0581A0CFE0B00A107290A302B00841E64ECC38F46D72700700110FCE5CCFAAD3B92280A3089EAF3AAEF33FEE1275BEB13002A6830F8E3908A77576CDD4E41808954DFB70E6A612E80DDD4A2FE46750600F943B7D158F087E96FAFDA462180C9D418602E809FDCED4900F8370D05BB05872DDC4201002AFE33169813E0072F781200426928D8A96D97916905A5E5E798FC818A8B6A2CC89838C4DC009B4DF724006CA0A160A30B5BA277B2E80FA8627354523273036C16E9490028A1A16097DE83A64630E1035FD76BE09418E608D8A8B4D600207FE0161A0976AE444DCDCC2D60B207BEEE607A4E714BAE6087BDBE5D5B00789206825D42C62FDAC4440FD4BA20308AB90236FA6D6D0160200D04BBECDC7BE800933C50B31DC90732992B60A32EB50580D934106C5AF9CF71BF8007DA760EC962CE804D26D61600C26920D861CC94773733B903751B35E99D68E60CD864436D01209F06821D92F71FE6C63FC0038929A939CC19B04976B50140FEC5D56A8F360D045F6BD3694406133BE039193305CC1DB0E31C16F1CDEA02C0CF691CD821A8575802933AE0B98EBDC6A63077C026F7551700B80300B6E833743A87FF00F5F0CA90691C0A04BB3C575D00789586811D464E58CCAD7F403D848C5F14C9DC019B84561700DEA6616087398BD74632A9039E9BBDE8237602C02E1F54170038810AB658B331963500403DACD91893C8DC019BC45717008A6818D8615364E26E2675C0736ACC3077C026F95F0900F23F5C43A38000001000E07A95A249D500F00B1A05040080000023DC5235003C46838000001000608416550340071A040400800000233C53350070060008000001006678A56A00984C8380000010006084F15503C0521A040400800000232CAD1A0022681010000002008CB0BD6A0048A5414000000800304276D500F0290D02020040008011CE8AC6AAF85F4963800000100060941B5400B88D860001002000C0283F5201A0050D01020040008051EE5301E09F3404080000010046F9B30A005D690810000002008CF2B40A00FD680810000002008CD2510580D7690810000002008CD2470580B1340408000001004619AE02C0341A020400800000A34C5201603E0D01020040008051E6AB00B08C860001002000C0282B5400584B43800000100060946D2A0084D31020000004001865A70A00093404080000010046495501603F0D010200400080510EA900904D4380000010006094741500CA680810000002008C92A902C0091A020400800000A36411004000000800304F8E0A0047690810000002008C92A702C0111A020400800000A314B008100400800000F314A900504C43800000100060946215000A6808D869E5FAE81D4CEA80E73EDA149BC4DC019B95AA00904343C04E6FCE5D19C1A40E786EE1FB1B63983B60B3721500326908D86948C8DC702675C07313677E10C5DC019B1D5101E0300D013B757D65421C933AE0B961A3E7453377C066152A00A4D210B053DB2E235399D401CFF5E83F3991B90336CBE53640F8C33199D42E30B103752B2CABB8D8AA637039F3066C76500580141A02763B989193CBE40ED42D61772A37B4C21F125500D84543C06E13672CDBC2E40ED46DC6BCD57CFF0F7F08570180EF9A60BB369D46641696559C6782076AD7F9E5719C01007F58AB02402C0D017F58BF75473C133C50B35DFB0EAB73592E305FC00F96AA00B08186803F74EF3B3186491EA8D9ABC1B3D9FF0F7F99AB02C0BB3404FCE4DCC18C9C02267AE0EB32F20A8FC91839C13C013F99A202C0341A02FE121CB6602B933DC0E13F08B8501500426808F8F32DC0B698E414267CE0BFB627EE3D2463A392F9017E34580580BE3404FCA975D088FC8CDC82234CFC40C5C582D2B2CA765D430F3137C0CF5E5201A0030D017FEBD677223B02003172C2625EFD2310825400788A864020CC98B78A6B8261B4F9EF7DCC366C044A2B15007E474320404E47C4EDDE4B218089D66E8EDBA9D6C4300F20401E5701E01E1A02017472E9CA6DB1140498645364E26EE9FBC719FF08A0FB5500B8998640805D089DB824BCB08C1B03E17E33E7AF8EE1933F1CE0161500AEA221E0043DFA4F8ECD2D2A394991801BE5979456F67F7D661C631D4EF8D0252EFBC6C58B175508384D83C0099EEB167A202BBFE8330A06DC64C3B61D7BDB761999C518874394A8DAFF450028A441E014EFAF0E674D005C61DFA1ACA21EFD27EF605CC36176570D00FB69103845DFA1D3A3281ED0D9E6A89D7B7B0F9A1ACBDB5538D486AA0120820681734E0A0C2EA2884047AB366CDFF96CE7906CC6311CEEEDAA0160010D0227D9B1FB601A0505BA69D7752447FA420723AB068037681038C9C4991F845350A093F8E403E98C5D68A267D500F03C0D0227E9D873EC4E8A0A74F2FAE8F9918C5D68E25F5503C0EF691038CC99ECC262B603420B8565E5E75B070517336EA189165503C0F7691038CDCAF5D171141768B2CF3F99310B8DDC5A3500341667691438C9C037DEE2B64068E1E5C1D3B63366A191A65F06002B04B080058ED22668440EC5054E97535872B22517FB401FE55FD4FDAA0160330D03A7D9B5EF703A45064EB6E4C3CD318C556824B1BA0030878681D3BC3977C5368A0C9CACF34BE39218ABD0C8E2EA02C0101A064E2393EB0E8A0C9C2A2D33B754FA692563151A195A5D00684BC3C0814E65E41556506CE04453E7AC60EF3F74F3EFEA02C043340C9C68E682D57C0D00477AAE5BE841C62834F3B3EA02C04D340C9C4826D9BD141B384DD29EB40CC6273453F9C516C04B034023719206821325A6A4A65274E0248343E6708B2A7473E88B9AFF950060850056B3C2915E0B7D7B2B45074E919157F8297BFFA1A135B50580B934109CA855C7E0D282D2B233141F38C184E9CB58FC071D85D516007AD14070AA15EBA263293E08B4FC92B2735CFC034D05D516007E4B03C1A9BAF599400040C02D5AB63196F1084DFDA6B600D05C5CA091E050670F65E59550841048EDBA86A63116A1A9EB6A0C005608606B0B1C6BCAACE52C0644C07C1C9EB08771084D955C5AEFAB0B00CB69283855DB2E23D90E8880E9F2F2F89D8C43682AD29300308C8682936D4FD8BB8762047F4B4C49CD66FC4163533C09004FD25070B27EC366465090E06FFD86CD60F11F74D6D69300F07D1A0A0E772A2D33B798A2047F49CDCCFD44FADD69C61E34F6C33A038015022A682C38D9F0B10BB820087E133A71490CE30E1A2BABAED6D71400B6D16070B8A359F94547294EB05B4E61C999561D838F30E6A0B175F5090013693038DDF8E9EFF31600B69B3A7B39DFFD4377AFD727003C4F83C1E9E45359495E71E9298A146CBBF427B7E084F4B34F196FD0DCA3F509003FA6C1A083D98B3E8AA450C12EC1610BF9EE1FBABB70E90980B506002B0414D17070BA369D46641796955752ACE06BFB0F6797AB1D278C33682EADA63A5F5B00789F86830EDE5BB9358682059FEFFB7F6D461CE30B2EB0C89B00D09386830EDA750D3D48C1822F25EC3E98237DEB3CE30B2ED0D39B00700F0D075DACDB129F44E182AF74ED338133FFE116BFF626003412E5341E74F0C28BA353285CF085CD514907185370CBA9A9E2F27A07002B04ACA401A18B15EBA2E3296068A8E75F1C4D00805BC4D456E3EB0A00AFD080D0C5B39D43320A4ACBCF51C4E0AD656B2292184B7091110D0900F7D280D0C9AC859C0B00EFE49794554A88CC611CC1457ED79000D058700A16B43A1D30BBA0F838050DF5F5D682351CF90B3739262EF33A005821601D0D099D844E5CC21D01A897ACFCA293121ECB183F7091D575D5774F02C0401A129A399E9A915B446183A75E0D9ECD91BF3066FF7F7D02C083342474D36FD80CD602C0235BA377EEB7CE4B67ECC04DEEF44500B84C7DA2A231A199CAA43D69872970A84D6E71E999673B8764335EE0325975D5768F0280150256D3A0D04D9797C7EFA0C8A18EDBFEA2192B70A1D9BE0C0041342874F4FEEAF0ED143A542736695FBA7A53C438810B3DE3CB00F09D965C8C013DB7059666E4165450F05055416959E5735D430F3146E042AA565FE7B30060850056C9424B2F0F7E338AA287AAC64D5BCAAB7FB855BCA775BD3E0180ED80D0D6DACD71AC07C07FECDC7B489DF6779A7101138FFFF53600DC45C34257AD8346E46517167F4601345B6159F9C5177A8CD9C79880A9C7FF7A1500AC109046E34257AF06CFE68440C3CD98BF9AAF32E166E5751DFFDB900010460343E7C531E131C9C9144233ED4BCB2CE64C13B8DC9CFAD4F4FA0680876960E8ECD9CE21E97925A5A72888E6E9FCF2B85D8C01B8DC23760600753B60298D0C9D8D18B7680B05D12C13677EB09DBE0F5EFF3720005821601E0D0DCD9D8DDBB57F3F85D10C1B2312F772E00F0C30B7BEF5DC9B00F0140D0DDD3DD735747F4169F9390AA4BB1D389C5DD6AA6370397D1E0678D41F01E06A7192C686EE26CC58C657012E965F525AF9FC8BA30FD0D761808AFABEFEF72A00582160150D0E1738B9FB407A3AC5D29D5E1D313B963E0E43BCED4D2DF736003C4383C3155F05740BDDC7AE00F759F2E1E644FA370CF2983F03C015E2088D0E3718F0C65BE1144DF7884F3E90C5D7943088AAC597FB2D00582160260D0FB7904F8C5C1BEC02197985279EED1C924B9F8641E6795BC71B12005AD0F07091E38929A91914519DCFF9AFB8D8BDEF440EFB81691EF77B00E06E00B8F094C0CCFC9232B6066A6AEAECE52CFA83693EF1F6F5BF2F02C0501E00DC2423AFF028C5544FBD074DDD411F86616637A486373400FC405CE0218000000200E077F7072C005821601B0F010400100000BF4A6968FDF645007881070102000800805FF5764200B8A625776C8300000200E02FA7C475010F00560858C4030101000400C02F96F8A276FB2A00FC95070202000800805FFCD14901A0B1E0F42D1000400000EC75C81775DB67018033014000000100F08B414E0C00FF632D4CE0018100000200E07BE7C48D8E0B00560898C7030201000400C0162B7C59B37D1D007EC9030201000400C0168F3B360058212092870402000800804FA985F68D9D1E009EE6418100000200E053037D5DAFED08004D44360F0B04001000009F382ABEE5F800608580013C3010004000007C629C1DB5DAAE00709D38C1430301000400A041CE8A5BB40900560898C9830301000400A04116DA55A7ED0C0077F3E0400000010068907BB40B005608D8C4C30301000400C02BEBEDACD1760780277880200080000078E54F3A078046229987080200080040BD24DA599F6D0F005608F8270F1204001000807A69E58600C05B0010004000003C97A10ED5D33E00F0160004001000807AE9E98FDAECAF00C05B001000400000EA562CAE764D00E02D0008002000001EE9EDAFBAECCF00C05B0010004000006A96239ABA2E00F0160004001000805A05F9B326FB3B00F016000400100080AF4BF3C7CAFF800500DE02800000020050AD36FEAEC7810800BC058063E515979EA6986A1B00E2E9C3D0548AAA8DAE0F00BC0580839DA490EAABFFEB3363E8C3D0D49381A8C5810A00EA2D40020F1D4ED23A28B89842AAAFE0B085D1F46368282E1075386001C00A010FF3E0E1246DBB8C3C4C21D5D7A4991F1000A0A3BF181700AC10F03E0F1F4ED1A977581285545F6FBFB33E967E0CCD6C0D640D0E7400B8559CA213C00982C316865348F5B57EEB8E14FA3134D3C2D800608580503A019CE0C38F22E329A4FACAC82D382ECFF1027D199A5819E8FAEB8400708D28A23320D0F61FCE2EA490EAEDD9CE21D9F4656840BDF9BEDDF800608580203A0402A94DD0883C0AA8FE5E1E3C2D8EFE0C0D0C7742ED754A00682C76D12910286F8C5D104101D5DFDC25EB080070BA2C711501E0AB21E00F740C044ADCAEFD691450FDA5E7161C95E779863E0D07FB9753EAAE630280150296D339E0F7FDFF9D43D2299EEED1BDDF44EE0480536D7452CD755A00B8439CA693C09FA6CC5ECEEB7F1759BE36923B01E04467C55D0480DA43C0583A0AFCA555C7E092DCA212EE007091FC92B233F25C8BE9DF709830A7D55B270680E66C0B84BFBC3977651445D37D66CE5F1D41FF868314A82DEF0400CF42C0D37418D8AD755070917CFAE7FA5F77BE0538DBA6D3883CFA391CA29D136BAD23038015023EA4D3C0E693FF122996EEB5F0FD8D6C0984134439B5CE3A3900DC248ED079608757864C8BA548BA5B4169F985E75F1CBD9FFE8E00AA14BF20007817023AD081E0FB57FF230A33F30A3FA348BADF9ED48CC2561D871FA3DF83857F9A05002B046CA213C1874E6F89DEB98FE2688E77966F49A0DF23000E8A2B09000D0B00B789E37426F8C0F9656B22765014CDD3F7B519B1F47FF873AE6919E0AB7E5D1100AC10F0121D0A0D3573C11AB6FC99BB2BE05C9797C7EF641C8057FFFA0500755910091EDEBA307EFAFB9CF66738B5E5B343CF317B180F30FDD5BF5601C00A017773C907BC7072E9CA6DACF8C77F64E5179D68DF7DD441C6054C7EF5AF5D00B042C0303A18EA73CC6F547C0A0BFEF015398525A77A0D9CC27D0130F6D5BFAE01E072914227435DBAF59D187F3023A79882879A4C9EF561B4B54F9B3103A35EFD6B1900AC10F02BBE0A408D7BFC3B06172F5B131147818327364624A67064304C7BF5AF6D00B042401F3A1C2E71F6D5E0D9911979859F52D850AFC581C5A567C64E7D2F4AFAD009C6114C78F5AF7B006824D6D3E9A0F4E83F3976F781C3D9143334C4FE435945BD064E51F7075C605CC1CDAFFEB50E005608F84E4BAE0D36DA0B3DC6A444B2C80F3EB623F9607A8FFE93E20902F0E4CDA3B85FD73AAA6D00B042C0230C52F33CDB392463C5FAE8048A15080208B03E3AD750AD03801502C2E884E62CF09BB3786D5441697925050A040104D86ADDEBA71B0280DA1A98486774B5CFC64C79373CA7B0E4040509040138408EB89E00E08C10F023C1959F2EFC7E6D50F0ECC843D979E514201004E010E7C4436EA89DAE08005608684FC774D3CAFE4971ACEC0741000E34C02D75D33501C00A018BE99CACEC070802B0C93AB50D9D00E0CC00D04CA4D34959D90F1004E063EAC4C81BDC54335D1500AC10F06B719ACEAAC9CAFEA0E092398BD746B3B21F04013898BA33E2B76EAB97AE0B005608E84087D562657F042BFB4110800686B8B156BA3200582160129DD6B92BFBD3B258D90F7382C08B04019D6D74D3F7FEA6048026620B9DD7592BFB93F7B3B21F0401E6036D64BAED7B7F2302801502AE171974E2C0AFEC8F88DBCDCA7E8020A01375B6CCCFDC5C235D1D00AC10708FFABE99CECCCA7E8020000F9D174FB8BD3EBA3E005821E05F0C3256F603040178A8BF09B5D1880060858037E8D4FE59D99F5D58CCCA7E8020A0ABF9A6D44593024023B182CE6DCFD9D8ACEC0708022EB05D342500B833045C23F6D2C97DE7C57E93E259D90F10045C205BFC8F4935D1A8006085803B44059DBDC12BFBF7B0B21F2008B8E5EB4BF1BFA6D543E302801502FE24CED0E9BD5AD99FB9625D142BFB0182809B56FCFFC3C45A686400B042402BEBC133003C59D9DF9195FD806382403F82800F0D32B50E1A1B00AC10D093CE5FA7E3ACEC0708022E35CFE41A687400B042400883A08695FDC36745B1B21F707C10384C10F0CA2A75643C0180103087C1C0CA7E8020608C7071A5E9B58F00F0DF8B8356B1B27FCC9EC8B8DDFB994C0182808BED14CDA97D0480AA21E04A11CDCA7E000401D74A336DAF3F01C0F31070AD490705A995FDB317B1B21F200818214FFC805A4700A82D04DC2C725CBFB27FF2BB91ACEC0708028628177753E308009E8480BBAC0EC3CA7E000401FD4FF9BB9FDA4600A84F0878D0EA38AE59D9BF6B1F2BFB01181504D489AF7FA1A61100BC09010F8B637AAFEC1FADCEEC67653F80DA82409C0B8340A5F837B58C00D09010F01B1D43805AD9BF9C95FD00CC0C02EA98F70ED43002802F42C043E2A85E2BFBCB58D90FC0C420A03EF93F47ED2200F83204B470780860653F00D383C039D19A9A4500B06B61E0A74EEBF003D5CAFECC5C56F603B021081C38A44910382B9EA6561100EC0C010F382504B0B21F0041E0CBD5FE4F52A30800FE0801F78B4F58D90F80201070A7C4DFA84D04007F86805F8B23ACEC0740100858F13F29FE8F9A4400084408B8CF1F218095FD0008025F5FF82CFE482D2200043204FC4A94D8D5C1474F7E8795FD0008025FA5CE66F92D358800E08410F04371C8971DBC47FFC9710733724A995800E81604BAF599B0C3C6E2AFD65FB5A0F610009C14026E10F10D7EDD1F34A260F5C731894C240074B67EEB8E5D6D3B8764F8B8F8AB9B5A7F4ACD21003831045C2DD6787B7AD5D0917323B20B8B8F3379007083FC92B27353662F8F6AD5D127C7A9278BEF516B08004E0E014DC45BF5E9D8EDBA861ED89EB8976D7D005C292D33B7A2CFD0E9B10D581FB05134A3C61000740902433DE9D8C346CF8B28282D3FC72401C0ED22E353D29EEB165ADFF552F3C465D41502806E21E079EB78CAEA3AF58977576C8D65520060D6D702A5E7068F9813EB61F11F4E2D2100E81C021EB9F43AE1369D46E4C5EF3A7098C90080A996AEDC9668EDE5AFE9529F206A0801C02D670514AA8EDDA97758727A6EC1A74C00004CB76BDFA1DC765D461EAE668FFFA3D40E02809B42C0AD23272C5E5B505A7E9E810F009FCB292C39652D10BC687D50FA15358300E03AD2D96F159CE50F009798B364DD2A29FE3FA0561000DC1C02AE103319F000F0A5B5E23A6A0401C09420D05E70C63F0093A90BCE068B46D40502806921E07FC521260100062A167FA21610004C0E01CDC572260300068914DFA5061000F07910E82F381110809B5D10630527FB1100704908F8BD28629200E0429F88A798EB0900A83904DC64BD1E63C200E016BBC41DCCF10400D41D022E13E3983400B8C06C7125733B0100F50B024F8BA34C200034A4B6393FCF5C4E0080F721E04EB187C9048046D2C43DCCE10400343C045C2D1631A900D0C032D18CB99B0000DF0681EEE234130C00073A2B5E62AE2600C0BE10F04B6B452D130E00A7C8112D98A30900F0CF2E8141E214130F800052D79B4FE3953F010081592018C124042000F68987988B0900085C086824BA8A4F999000F8815A87344C34650E2600C01941E066B19AC909808DA2C44F9873090070661068254A98A800F8907AC3D84DBD71649E2500C0D921E07AB180490B800FA8EBCAB9BA970000CD82C023228B090C8017F2C53F994B0900D037047C534CB6B6EB30A901A8CB05314334670E2500C01D41E0416BDB0E131C809A1C100F33671200E0BE10D054BC21CE30D101A842CD09C3D9DA470080FB83C0CF441C931E00B15DDCCDDC4800803921A0B1784E64320102462AB12E18636B1F0100860681CB454F51CC840818E11331542D10660E2400005FEC1618CA91C2806B9D10A3C575CC792000A0A64384C2C449264CC0350BFCDE143731C78100004FEF169825CE3181025AAAB44E04BD8D390D0400787BE5F052EB70102655400F1FB2B21F0400F82A08FC4A6C6062051C6DA3B88F390B0400D81104FE20629968014789516393390A0400F82308FC43EC65E205026AB778823909040004E230A1F6DC3808F8DD21D186437C40008013EE18E8C6654380ED3244677119730F0800705A18F89358616D4162C2067C733DEF7AF1B87AEBC63C0302009C1E04BE2F4689322670C0EB237B27881F32A78000001D83C015E20591C8840E78BCB0AF8BB89A39040400B8250CB4104BACA34999E881FF3A6B1DB8F55BE60A1000E0E62070A318260A98F861B842F186F82E730308003029085C265A89280A010CA3FA7C6B751D3773010800303D0CFC42CCB1AE2CA540C0ADD7F1CE163F67CC8300007C3D085C27FA59FB9D291A7083C3A28FB896310E020050771068642D1A1C471880868AC44CF1174EEB030100685820F8A5081107282E70A82C6BDFFEC31CD8030200604F18F889182A76517410602A908E54D7653336410000FC1B066EB7D60CC45A47A6529460B72431440551C62008008033C2C0F7444FB18DBB08E043E745B4B590EF56C61A080080B3C3C00DA29375890A270FC29B93F9365AB75CDEC898020100D0330C7C4BB4B36E29FC8CE2861A9C14ABC4F36A3B2A63070400C07DA70FAAED8583AD4F78C7297CC62A162BC5006BE5FE958C111000007302C1E5D6E4AF76156CB13E05521CDDA7D2BA656F86784EDC41FF0701804600AA0682A6E277D665451B4419C5534B9F58CF6F987518CF35F46F800000D43714DC265A8AB1D60E83A314584751DB3F53C53CD159FC94D3F700020060D731C57759AF92A788181617FA956AEB70112A9E10D7D32F01020010C860708BF83FD15B4CB7DE161452B0BD5668B5A1FADEFE25F188F8019FEE010200A0D336C407C50B628C582E124589E1A7175EB056E227596D32CADA82F780684EDF010800809BC3C115E287E24F56F17B4DCCB20E30DAA7F97A830A6BE5FD47D6A7F8C1D6D7267F50ABF0D5EF4E1F000800006ADFAAF81DEB12A487C4E35621555F35BC2E268985628D88B0EE45509FAA53C441912E72AC2B6ACBC53171CA3AE2F6BCF5CFC7AC7F5764FDD974EBA29B14EB6D45ACF5BDBB3A2867BE9868851575F4F2B3E231EB2DC79DD6298C4D787680B3FD3F6A5B61BFA2D238BD0000000049454E44AE426082);
INSERT INTO `tbl_basicinfo` VALUES ('33', '9172016 - 2', 'De leon ', 'Chadwick ', 'Urbina', '1999-04-27', '17', 'Male', '5\'7', '80', '176 flora st. Marick Sub. Cainta Rizal', 'Police', '090 952-13367', 'Without Philhealth', 'Out - Patient', '10:38:25 AM', 'September 17, 2016', 0x89504E470D0A1A0A0000000D4948445200000200000002000806000000F478D4FA0000000473424954080808087C0864880000000970485973000085B6000085B601A9B9F3CC0000001974455874536F667477617265007777772E696E6B73636170652E6F72679BEE3C1A000031F04944415478DAEDDD777CD5D5FDC7F1028AA342D5FAABB6DA3A5A6B6DFD756855ACDDED4FADD6DA5A198228842943650B88124218612343866C1551A60C995964900442980964EF89826C02FC3EA77EB511336E6EEEF7DEEFF99ED71FCFC7C347A5989CEF39E7F3BEDF7BC6372E5EBCF80D00CED5B2C3F0A6E216F133F11BF198682DBA8A0122444C150BC52A112E768A54715864886C912BF245912811E5E288382A3E13272C65D69FDF2F12ACBF6FAD5826E68B6962AC785DF4B37E8E7F8A16E2367125CF0D703E1A01086C71BF4AFC48FC513C275EB50AAC2AE449A2585C101735F3A9154022C45231D9FADD3A5801E617E21AFA00400000DC5CE4AF170F8BCE6282F848ECB63E815F349C7A1B1125DEB602C2BFC5CFC5D5F41D800000E852E86F167F15BDC50CEBD5793145DE2B17ACAF2B541BCE1603C593EAAB10FA1A4000000255E89B885F5ADF7DAB4FAE3BACEFD129DCFEA1D62F6C10A1D61B83DBE897000100B0A3E0FF403C23C659AFAB4F50841DA7426CB11627AA0592778A46F45F800000785AEC9B8B3F8BC1D642BC228AABB6D45B998FADB5050F89CBE9E3000100F8A2E05F6115FC51D696B7F3144ED73A2E368921D6A24C02010800804105BF91B8D75A54A68AC1490AA3B14E585F1BBC267EA7CE5B608C800000B8ABE8DF2EBA5807D9B0F50E35516170A3E8256E65EC800000E8B94AFF8FD6E9781914367829C53A65F101161482000038FBBBFC27AC6D7965142FD87060D11CEB2C82AB1873200000812DFACDAC2D5FEAA8D9631429F8F1AB8235D6C98E373216410000FC53F46F1041D6E534A7294608B04A6BAB617BEE36000100F07DD1BFD2FAA4BFC19A70293C70EAAE82F7C4DFD962080200D0B0C2FFA098293EA1B840336A1DCA74757D3363190400C0B3A27FB37572DB418A085C22538C147733C6410000BEFE8ABF8DF55D2A27F1C1CDE2C5F36AD70A631F0400985CF8EFB15EF17F4A6180815F11A88B8B6E672E000100A614FDC6E21F622B4500F8CF1BAF75D619168D99234000801B0BFFB7441F4EE6036A5D2B30486D7565CE0001006E28FC778969E2332678C023EA7C8B456A170C73080800D0ADE8AB1BF7FE66EDDBBFC0840E782D523CCABC0202009C5EF82FB76EDD4B63E2067C6AA7788675022000C069855F5DC4F3A2C861A2066C952A3A72D220080070C2FEFDDE229F8919F0AB5CF192B89AB9080400F8B3F05F6DADE82F62220602AA540C55BB6C989B4000809D85FF1A31509430F1028E7254BCCE8D842000C0D785BF991822CA996801472BB1BE966BCADC0502001A52F82F133DF8C40F6879A8503BB52597B90C0400D4B7F83F65AD38663205F4B55B3CCE9C0602003C29FCF75B878F307902EE3A50E821E6381000505DE1BF5DBCC7C97D80ABAD143F65CE030100AAF05F27C68B334C8E80112AC59BE25AE6400200CC3DB6B7AF38C28408187B864047160A12006056F1FFBDD8CF040840C4897B991B09007077E1BF41CCE37B7E0097382F668AEB992B090070DFF5BC1D39C807401DCAAD1B3DB9759000001714FF9F8A28263600F590201E600E250040CFC27F951825CE329901F082FAAAF02DD19C399500007D8AFFDFACA34099C400F8E2EAE147995B09007076E1FFB658CA8405C0066F73ED300100CE2CFE4F882226290036CAE76E0102009C7555EF1C2626007EB4409D22CA1C4C0040600FF4E1BB7E008150289E642E2600C0BF85FF0AEBFCFEF34C4200026C0907081100E09FE27F2FC7F8027018B5FEE8AFCCD10400D853F82F13C3D8D70FC0C1C709878A26CCD90400F8AEF8DF2AE29960006860BBF83E733701000D2FFE4FB6E4CA5E007AA9104F31871300E0FD2BFF306EEE03A0B129A229733A01009E17FF9B453493070017D8297EC4DC4E0040DDC5FF1151CAA401C0458E89B6CCF10400545FF81B8B60F6F60370B1B9EA1C13E67C0200FE5BFC6F145B991C001840ED68FA2E733F0180E2FFF971BE854C0A000C5220EEA70610004C2EFE5D38D80780A14E89F6D40202806985BF8998C4040000C3C7A93550D406028009C5BFB958CFA007802F6D10D7522308006E2EFE7770910F00542B4DDC45AD2000B875B15F39831C006AF4A9789C9A41007053F1EFC4623F00F0883A0BE5156A0701C00D87FB4C60400380578B031B514B08003A16FF6F8A750C6200F0DA3BE2726A0A0140A7E2FF6DEBB42B06300034CC66D18CDA4200D0A1F8DFC24A7F00F0A9647113358600E0E4E27F97C861B00280CF65891F536B08004E2CFEF7B5E41A5F00B093DA4ADD829A43007052F1FF73CBCFEFBB66800280BD4E88BF537B08004E28FE4F8BD30C4A00F09B4AD1811A44000864F1EF6C7544062400F8D705D1855A44000844F11FC4000480808780EED42402803F8BFF30061E0038462F6A1301C01FC57F08830D001CE7656A1401C0CEE23F904106008ED58F5A4500B0A3F8F763700180E30DA46611007C59FC5F66500180368650BB0800BE28FEBD184C70B833AD3A061F691D34A2A06DE790F4F6DD47ED0BEA357657B73E13E27B0F9ABA7DC01B6F450E1B3D2F62D4A477C227CFFA3062F6A2B5514B3EDC1CB3627DF40E45FDB3FADFD4BF537F46FD59F5FF51FF5FF577A8BF4BFD9DEAEF56FF0DF5DF52FF4DDA1D0E378C1A46006848F1EFCE2042A04F3D6BD775645ACF01936343272E097F67F9969898C47D07F71DCA2A48CF29389257527AA6A8BCE26220A8FFB6FA19D4CFA27E26F5B3C9CF18A17E56F533CBCF7E92E787001B442D23007853FCBB587B4C1944B05DEBA0E0A28E3DC7EE1A387C56E4B4B92B23D66D894FDC9B96995F585671215005BEA1D4CFAE7E87B59BE392D4EF24BF5B94FC8EC9F2BB16F3CCE1479DA9690480FA14FF0E147FD8E47450AFB0A490F18BB72DFE60D3F6ED897BF767E5177DA66B91F796FA9DB727EC3D206D1013327E5184B4C92EBE56808DC7063F4D6D23007852FCFFCEF1BEF0A5369D46E40C0A9E15BEEAE3ED3B720A4B8E9B56EC3D955D587C62D586ED89EA4D81B4591E7D07BE0CDEE2CFD43802406DC5BF45CBCF6F9A62C0A0214E767E695CC2B4B92BC393F71FCEA4B87B67D7BE43D96FCE5911256D99246D7A8A7E85065237B6DE47AD23005457FC7FDCF2F3BBA61928A8B7673B85640E0E9913BE76735C426E51C9490AB86F499B9E5AB33176E7E0117322DB740AC9A6CFC14BA5E22E6A1E01A06AF1BF4964313850BF57FB21995367AF08DF7330238722ED5FBB0FA4E74D99BD3C8A30002FE4885BA87D040055FC9B896406053C15D42B2C71F5C731F1856515E729C681DE69507E61D586ED09EAAC02FA26EA61BFF83601C0ECE27FB9D8CC608027FBF1FB0D9B199198929A4AE175A684DDA987FA0D9B11C5F903F050BCF82601C0CCE2DF48BCC320401DFBF30BC64D7B7F4B7A6E411945560FE93905E5E3A62DDDA69E1D7D187558271A1300CC0B00E3E8FCA849FBEEA376BFB7726B544169F9198AAA9E0A4ACBCEBEB7626BB43CCB14FA346A3181006056F17F854E8F1A0A7F4A547C4A3205D45DD4332508A0169D08006614FFC7C5793A3C2EF1E9CCF9ABB7159655545230DDBA60B0A2523D63F5ACE9EFB8C459F17B0280BB8BFF5D0C7E5CAA47FFC9DB5333728B28926650CF5A3D73FA3E2EA1CE81B98300E0CEE27FAD48A393E3CB7DFC4123723FDA141B4F5134937AF6AA0F301670C9F6C0E604007715FFC662039D1B96736F8C991FCEB9FC507D40F505D5271817B0AC174D0800ACF887CB3CDF7DD4DE1DC907D2287EA84AF509D5371823B04C2200B8A3F8B7A7334319396171B8BAA39E82871A16095E089DB8389CB1024B170280DEC5FF7E6E118338B368D9C6288A1C3CB1F0FD8D6A81E019C60D3B03DCBE33C0CDC5FFBB8293C00CD7AA63F091CD5149BB286CA88FCD9149C9D2773E610C19AF50DC4800D0ABF85F619DF34C0736FAB6BE1159BBF61D4EA7A0C11B3BF71ECA943E94C35832DE56B71E17ECD60030974E6BF862BF1747EF4ACFE1FC7E34CCE1ECFC72E94B7B1853C60B2600E851FCDBD259CDD673C09488BC92D2931430F8426E51C9A99E0326C730B68CA64E8F7D8400E0ECE2FF23718CCE6AAEE163177C2C93F6790A177CBD43E0F5CFCF0B609C99AB54DC4C007066F16F2A76D249CDD5F7B5199B2956B0539FA1D33942D86CD1E2320280F302C0143AA7B9827A85EDE0EA5ED82DBFA4EC5CC75E63931973460B230038ABF83F45A73457DBCE216959F945472850F0878CBCC2A3CF760EC964EC19EB82789200E08CE2FF7D5141A734769F7FC9DEB4CC2C0A13FC29E56046BEF4BD72C6A0B18E885B0900812DFE4D04DFC999EB44F48E3DBB29480884F0D8E4039C346AB478DDD703E81E0042E984E66ECBF9604D4434850881B474D5B604EB953063D24CC308008129FE7FB5F666D2090D14F6E65256FCC311C64C79379A3169F47D01F71200FC5BFCAF1745743E33B5EF362AA5B0ACBC92E2032728282D3F2F7D3295B169ACFDEAF8790280FF02C0123A9DB937FB25EC3E7880C2032789DBB93F5DFAE639C6A7B1C61300FC53FC9FA4B3996BC4F845BCFA872305872DE4AB00B38F0AFE3D01C0DEE27F9D753D231DCE40CF760A49E78C7F38F8CE8033D247B93DD05CEA6C88660400FB02C0023A99B9876F6C89DE9944A181936D0C4FD8CB5835DA1C02803DC5FF713A97B9FA0F9BB98D02031DF47D6D462C63D6684F10007C5BFCBF25F2E958C69EF65794C951BFD0447A6EC131E9B3658C5D63A91D6ADF2600F82E00BC4DA732D7D4D9CBB75058A093496F7DC009A5665B4A00F04DF17F94CE64F4A7FF8A9CC2E2631415E8242BBFE8A4F4DDA38C61A33D46006858F16F2E72E948E61A396131DBFEA0A511E316B12DD06C19E22A0280F701E02D3A91D997FD1CCEC92FA1984047A999B9EAC6B8D38C63A38D24007857FC1FE0920DB30D0A9EB59542029D0D7CE3AD18C6B2D927978A9F1000EA57FC1B8B043A8FD1CEED4DCDCCA4884067C9FB0FE7736999F1B61100EA1700BAD069CCD66BE094480A08DCA0E780C93B18D3C66B4F00F0FCA6BF723A8CD936472525523CE0061F8727EC614C1BAF441D654F00A83B00CCA4B318BFF5AF98EB7EE1A6EB82A54FF3A1066F11006A2FFEF7F27D19060E9F154EE180CB1603723010D4A2F6160480EA8B7F23114727C1E6A8A49D140DB8EA92A088C414C636C46ED18400F0F5001044E740AB8EC125BCFE874BBF06E07E00283D08005F2DFED78A523A06060E9F1541C1802BBF06183E2B8A310EABD6352700FC3700BC49A7C07F5EFF472625532CE0469B22137733C661194500F8BCF8FF5454D221A08EFE2D282D3B47B1803BBF06283BA7FA38E31CE294F83E01A0C3F0957406281D7A8EE1D33F5CAD438F312C06C41716191D00A4011EA213E00BC1610BB75124E066C3C72E8864ACA3CAB6C07B4D0E000C067C69D586ED711409B8D98A7551498C7538E59E804016FFC779F8A89A86D3730A4A291270B3B4ACDC4F18EBB8C4DF8D0A00D6A13FAC88C597DA741A9141818009A4AFE731E651C50171994901A01D0F1D55F51E3495DBFF60845E03A7703B202EF5A21101407ED1A62293078EAA464D7A6733C501261839617134631ED5DC16D8CC8400D09B878D4B2D5AB68913006184F9EF6D8867CCA31A435C1D00E417BCC64A3A3C6C7C45786C321700C1089BA392F633E6510D7565F4356E0E00AFF390519DB4CCDC7C8A034CB0EF505639631E3518E8CA0020BFD8B7C4511E30AAF1994C8CE7290E30416159B9EAF36718F7A8612DC0D56E0C004378B8A8610B603A8501866D05CC67ECA3067D5C150054A2E1BA5FD4A46D979107280A3089F4797642A12645E24A3705809778A8A849FBEEA37653146092F6DD46A532F6518BDEAE0800F28B5C2E7279A0A8F116C01E6392280A30C90B3DC6EC63ECA316EA2BA22BDC10003AF230519B4EBDC3E2290A304950EF308E4247C04F07B4BBF83716BCEA42ADBAF5991043518049BABE326127631F75C8516FD0750E00CFF01051979E03A644511460921E03262730F6E1812E3A0700522EEAF4CA9069E1140598E4E5C16FC631F6E101F506BD917601407EE8477978F0C48037DEDA46518049FA0F9B19CBD887871ED3310044F2E0E089BEAFCDE00D008CD267E8F418C63E3CB44EAB00203FF0833C3478AA7BDF89B114059844FA3C6B00E0A90BE24E9D02C0221E1A3C3E07A0E798648A024CD2A1C79814C63EEA618A1601407ED01BC4691E183CD5AE6BE8418A024C227D9EEDD1A80F75915E331D02C0201E16EA170046A651146056001899C6D847A08F07B6E3E01F2EB90001002000C0B7D27CBD25D0D701E0091E120800000100CEDF12E8EB00B08E070402004000802DD63B3200C80F76BB38CF030201002000C0B62D813F76620018CBC30101002000C056931C1500E407BA4294F1604000000800B05599AF6E09F45500789E870202004000805F3CEDA40010CF030101002000C02FD6382200C80F72370F030400800000BF39276E74420018C9C30001002000C0AFFA39210070F21F0800000100FEB52FA001407E80DFF010400000080008885F0732004CE70180000010001010D3031200D43E44F6FE8300001000103047D4393C8108007FA7F1410000080008A856810800EFD1F02000000400E8794190B7C5FF1A718286070100200020A02AC50DFE0C00ED697410000002001C21C89F01E0631A1C04008000004758EB9700A08E1FB45E39D0E8200000040004DE69D1CC1F01A0338D0D0200400080A3B4F647005843438300001000E0284B6D0D00F21FB84A9CA4A14100000800709463F53D14A8BE01E0491A190400800000477AC2CE003087060601002000C091DEB62500C85FDC4814D1C020000004003892BA9FA7891D01E0011A17040080000047FBA31D012084860501002000C0D1A6DA110052685810000002001C2DC3A70140FEC25B69541000000200B470BB2F03402F1A1404008000002D74F16500D848838200001000A085653E0900F21735E5F43F1000000200B451AEB6EEFB2200FC8EC60401002000402BF7FA2200BC46438200001000A09581BE08005B68481000000200B4B2A9410140FE82CBC5091A120400800000ADA8B57B573424003C4C238200001000A0A53F3724000CA1014100000800D0D2A88604804D342008000001005A4AF02A0058DFFF1FA7014100000800D0D279D1CC9B00F0108D0702004000803BD701D416005EA5E14000000800D0DAABDE04808F69381000000200B4B6A25E01409D212C8ED2702000000400682DBFBE01E04E1A0D040080000057F85E7D02406B1A0C040080000057F8677D02C0581A0CFE0B00A107290A302B00841E64ECC38F46D72700700110FCE5CCFAAD3B92280A3089EAF3AAEF33FEE1275BEB13002A6830F8E3908A77576CDD4E41808954DFB70E6A612E80DDD4A2FE46750600F943B7D158F087E96FAFDA462180C9D418602E809FDCED4900F8370D05BB05872DDC4201002AFE33169813E0072F781200426928D8A96D97916905A5E5E798FC818A8B6A2CC89838C4DC009B4DF724006CA0A160A30B5BA277B2E80FA8627354523273036C16E9490028A1A16097DE83A64630E1035FD76BE09418E608D8A8B4D600207FE0161A0976AE444DCDCC2D60B207BEEE607A4E714BAE6087BDBE5D5B00789206825D42C62FDAC4440FD4BA20308AB90236FA6D6D0160200D04BBECDC7BE800933C50B31DC90732992B60A32EB50580D934106C5AF9CF71BF8007DA760EC962CE804D26D61600C26920D861CC94773733B903751B35E99D68E60CD864436D01209F06821D92F71FE6C63FC0038929A939CC19B04976B50140FEC5D56A8F360D045F6BD3694406133BE039193305CC1DB0E31C16F1CDEA02C0CF691CD821A8575802933AE0B98EBDC6A63077C026F7551700B80300B6E833743A87FF00F5F0CA90691C0A04BB3C575D00789586811D464E58CCAD7F403D848C5F14C9DC019B84561700DEA6616087398BD74632A9039E9BBDE8237602C02E1F54170038810AB658B331963500403DACD91893C8DC019BC45717008A6818D8615364E26E2675C0736ACC3077C026F95F0900F23F5C43A38000001000E07A95A249D500F00B1A05040080000023DC5235003C46838000001000608416550340071A040400800000233C53350070060008000001006678A56A00984C8380000010006084F15503C0521A040400800000232CAD1A0022681010000002008CB0BD6A0048A5414000000800304276D500F0290D02020040008011CE8AC6AAF85F4963800000100060941B5400B88D860001002000C0283F5201A0050D01020040008051EE5301E09F3404080000010046F9B30A005D690810000002008CF2B40A00FD680810000002008CD2510580D7690810000002008CD2470580B1340408000001004619AE02C0341A020400800000A34C5201603E0D01020040008051E6AB00B08C860001002000C0282B5400584B43800000100060946D2A0084D31020000004001865A70A00093404080000010046495501603F0D010200400080510EA900904D4380000010006094741500CA680810000002008C92A902C0091A020400800000A36411004000000800304F8E0A0047690810000002008C92A702C0111A020400800000A314B008100400800000F314A900504C43800000100060946215000A6808D869E5FAE81D4CEA80E73EDA149BC4DC019B95AA00904343C04E6FCE5D19C1A40E786EE1FB1B63983B60B3721500326908D86948C8DC702675C07313677E10C5DC019B1D5101E0300D013B757D65421C933AE0B961A3E7453377C066152A00A4D210B053DB2E235399D401CFF5E83F3991B90336CBE53640F8C33199D42E30B103752B2CABB8D8AA637039F3066C76500580141A02763B989193CBE40ED42D61772A37B4C21F125500D84543C06E13672CDBC2E40ED46DC6BCD57CFF0F7F08570180EF9A60BB369D46641696559C6782076AD7F9E5719C01007F58AB02402C0D017F58BF75473C133C50B35DFB0EAB73592E305FC00F96AA00B08186803F74EF3B3186491EA8D9ABC1B3D9FF0F7F99AB02C0BB3404FCE4DCC18C9C02267AE0EB32F20A8FC91839C13C013F99A202C0341A02FE121CB6602B933DC0E13F08B8501500426808F8F32DC0B698E414267CE0BFB627EE3D2463A392F9017E34580580BE3404FCA975D088FC8CDC82234CFC40C5C582D2B2CA765D430F3137C0CF5E5201A0030D017FEBD677223B02003172C2625EFD2310825400788A864020CC98B78A6B8261B4F9EF7DCC366C044A2B15007E474320404E47C4EDDE4B218089D66E8EDBA9D6C4300F20401E5701E01E1A02017472E9CA6DB1140498645364E26EE9FBC719FF08A0FB5500B8998640805D089DB824BCB08C1B03E17E33E7AF8EE1933F1CE0161500AEA221E0043DFA4F8ECD2D2A394991801BE5979456F67F7D661C631D4EF8D0252EFBC6C58B175508384D83C0099EEB167A202BBFE8330A06DC64C3B61D7BDB761999C518874394A8DAFF450028A441E014EFAF0E674D005C61DFA1ACA21EFD27EF605CC36176570D00FB69103845DFA1D3A3281ED0D9E6A89D7B7B0F9A1ACBDB5538D486AA0120820681734E0A0C2EA2884047AB366CDFF96CE7906CC6311CEEEDAA0160010D0227D9B1FB601A0505BA69D7752447FA420723AB068037681038C9C4991F845350A093F8E403E98C5D68A267D500F03C0D0227E9D873EC4E8A0A74F2FAE8F9918C5D68E25F5503C0EF691038CC99ECC262B603420B8565E5E75B070517336EA189165503C0F7691038CDCAF5D171141768B2CF3F99310B8DDC5A3500341667691438C9C037DEE2B64068E1E5C1D3B63366A191A65F06002B04B080058ED22668440EC5054E97535872B22517FB401FE55FD4FDAA0160330D03A7D9B5EF703A45064EB6E4C3CD318C556824B1BA0030878681D3BC3977C5368A0C9CACF34BE39218ABD0C8E2EA02C0101A064E2393EB0E8A0C9C2A2D33B754FA692563151A195A5D00684BC3C0814E65E41556506CE04453E7AC60EF3F74F3EFEA02C043340C9C68E682D57C0D00477AAE5BE841C62834F3B3EA02C04D340C9C4826D9BD141B384DD29EB40CC6273453F9C516C04B034023719206821325A6A4A65274E0248343E6708B2A7473E88B9AFF950060850056B3C2915E0B7D7B2B45074E919157F8297BFFA1A135B50580B934109CA855C7E0D282D2B233141F38C184E9CB58FC071D85D516007AD14070AA15EBA263293E08B4FC92B2735CFC034D05D516007E4B03C1A9BAF599400040C02D5AB63196F1084DFDA6B600D05C5CA091E050670F65E59550841048EDBA86A63116A1A9EB6A0C005608606B0B1C6BCAACE52C0644C07C1C9EB08771084D955C5AEFAB0B00CB69283855DB2E23D90E8880E9F2F2F89D8C43682AD29300308C8682936D4FD8BB8762047F4B4C49CD66FC4163533C09004FD25070B27EC366465090E06FFD86CD60F11F74D6D69300F07D1A0A0E772A2D33B798A2047F49CDCCFD44FADD69C61E34F6C33A038015022A682C38D9F0B10BB820087E133A71490CE30E1A2BABAED6D71400B6D16070B8A359F94547294EB05B4E61C999561D838F30E6A0B175F5090013693038DDF8E9EFF31600B69B3A7B39DFFD4377AFD727003C4F83C1E9E45359495E71E9298A146CBBF427B7E084F4B34F196FD0DCA3F509003FA6C1A083D98B3E8AA450C12EC1610BF9EE1FBABB70E90980B506002B0414D17070BA369D46641796955752ACE06BFB0F6797AB1D278C33682EADA63A5F5B00789F86830EDE5BB9358682059FEFFB7F6D461CE30B2EB0C89B00D09386830EDA750D3D48C1822F25EC3E98237DEB3CE30B2ED0D39B00700F0D075DACDB129F44E182AF74ED338133FFE116BFF626003412E5341E74F0C28BA353285CF085CD514907185370CBA9A9E2F27A07002B04ACA401A18B15EBA2E3296068A8E75F1C4D00805BC4D456E3EB0A00AFD080D0C5B39D43320A4ACBCF51C4E0AD656B2292184B7091110D0900F7D280D0C9AC859C0B00EFE49794554A88CC611CC1457ED79000D058700A16B43A1D30BBA0F838050DF5F5D682351CF90B3739262EF33A005821601D0D099D844E5CC21D01A897ACFCA293121ECB183F7091D575D5774F02C0401A129A399E9A915B446183A75E0D9ECD91BF3066FF7F7D02C083342474D36FD80CD602C0235BA377EEB7CE4B67ECC04DEEF44500B84C7DA2A231A199CAA43D69872970A84D6E71E999673B8764335EE0325975D5768F0280150256D3A0D04D9797C7EFA0C8A18EDBFEA2192B70A1D9BE0C0041342874F4FEEAF0ED143A542736695FBA7A53C438810B3DE3CB00F09D965C8C013DB7059666E4165450F05055416959E5735D430F3146E042AA565FE7B30060850056C9424B2F0F7E338AA287AAC64D5BCAAB7FB855BCA775BD3E0180ED80D0D6DACD71AC07C07FECDC7B489DF6779A7101138FFFF53600DC45C34257AD8346E46517167F4601345B6159F9C5177A8CD9C79880A9C7FF7A1500AC109046E34257AF06CFE68440C3CD98BF9AAF32E166E5751DFFDB900010460343E7C531E131C9C9144233ED4BCB2CE64C13B8DC9CFAD4F4FA0680876960E8ECD9CE21E97925A5A72888E6E9FCF2B85D8C01B8DC23760600753B60298D0C9D8D18B7680B05D12C13677EB09DBE0F5EFF3720005821601E0D0DCD9D8DDBB57F3F85D10C1B2312F772E00F0C30B7BEF5DC9B00F0140D0DDD3DD735747F4169F9390AA4BB1D389C5DD6AA6370397D1E0678D41F01E06A7192C686EE26CC58C657012E965F525AF9FC8BA30FD0D761808AFABEFEF72A00582160150D0E1738B9FB407A3AC5D29D5E1D313B963E0E43BCED4D2DF736003C4383C3155F05740BDDC7AE00F759F2E1E644FA370CF2983F03C015E2088D0E3718F0C65BE1144DF7884F3E90C5D7943088AAC597FB2D00582160260D0FB7904F8C5C1BEC02197985279EED1C924B9F8641E6795BC71B12005AD0F07091E38929A91914519DCFF9AFB8D8BDEF440EFB81691EF77B00E06E00B8F094C0CCFC9232B6066A6AEAECE52CFA83693EF1F6F5BF2F02C0501E00DC2423AFF028C5544FBD074DDD411F86616637A486373400FC405CE0218000000200E077F7072C005821601B0F010400100000BF4A6968FDF645007881070102000800805FF5764200B8A625776C8300000200E02FA7C475010F00560858C4030101000400C02F96F8A276FB2A00FC95070202000800805FFCD14901A0B1E0F42D1000400000EC75C81775DB67018033014000000100F08B414E0C00FF632D4CE0018100000200E07BE7C48D8E0B00560898C7030201000400C0162B7C59B37D1D007EC9030201000400C0168F3B360058212092870402000800804FA985F68D9D1E009EE6418100000200E053037D5DAFED08004D44360F0B04001000009F382ABEE5F800608580013C3010004000007C629C1DB5DAAE00709D38C1430301000400A041CE8A5BB40900560898C9830301000400A04116DA55A7ED0C0077F3E0400000010068907BB40B005608D8C4C30301000400C02BEBEDACD1760780277880200080000078E54F3A078046229987080200080040BD24DA599F6D0F005608F8270F1204001000807A69E58600C05B0010004000003C97A10ED5D33E00F0160004001000807AE9E98FDAECAF00C05B001000400000EA562CAE764D00E02D0008002000001EE9EDAFBAECCF00C05B0010004000006A96239ABA2E00F0160004001000805A05F9B326FB3B00F016000400100080AF4BF3C7CAFF800500DE02800000020050AD36FEAEC7810800BC058063E515979EA6986A1B00E2E9C3D0548AAA8DAE0F00BC0580839DA490EAABFFEB3363E8C3D0D49381A8C5810A00EA2D40020F1D4ED23A28B89842AAAFE0B085D1F46368282E1075386001C00A010FF3E0E1246DBB8C3C4C21D5D7A4991F1000A0A3BF181700AC10F03E0F1F4ED1A977581285545F6FBFB33E967E0CCD6C0D640D0E7400B8559CA213C00982C316865348F5B57EEB8E14FA3134D3C2D800608580503A019CE0C38F22E329A4FACAC82D382ECFF1027D199A5819E8FAEB8400708D28A23320D0F61FCE2EA490EAEDD9CE21D9F4656840BDF9BEDDF800608580203A0402A94DD0883C0AA8FE5E1E3C2D8EFE0C0D0C7742ED754A00682C76D12910286F8C5D104101D5DFDC25EB080070BA2C711501E0AB21E00F740C044ADCAEFD691450FDA5E7161C95E779863E0D07FB9753EAAE630280150296D339E0F7FDFF9D43D2299EEED1BDDF44EE0480536D7452CD755A00B8439CA693C09FA6CC5ECEEB7F1759BE36923B01E04467C55D0480DA43C0583A0AFCA555C7E092DCA212EE007091FC92B233F25C8BE9DF709830A7D55B270680E66C0B84BFBC3977651445D37D66CE5F1D41FF868314A82DEF0400CF42C0D37418D8AD755070917CFAE7FA5F77BE0538DBA6D3883CFA391CA29D136BAD23038015023EA4D3C0E693FF122996EEB5F0FD8D6C0984134439B5CE3A3900DC248ED079608757864C8BA548BA5B4169F985E75F1CBD9FFE8E00AA14BF20007817023AD081E0FB57FF230A33F30A3FA348BADF9ED48CC2561D871FA3DF83857F9A05002B046CA213C1874E6F89DEB98FE2688E77966F49A0DF23000E8A2B09000D0B00B789E37426F8C0F9656B22765014CDD3F7B519B1F47FF873AE6919E0AB7E5D1100AC10F0121D0A0D3573C11AB6FC99BB2BE05C9797C7EF641C8057FFFA0500755910091EDEBA307EFAFB9CF66738B5E5B343CF317B180F30FDD5BF5601C00A017773C907BC7072E9CA6DACF8C77F64E5179D68DF7DD441C6054C7EF5AF5D00B042C0303A18EA73CC6F547C0A0BFEF015398525A77A0D9CC27D0130F6D5BFAE01E072914227435DBAF59D187F3023A79882879A4C9EF561B4B54F9B3103A35EFD6B1900AC10F02BBE0A408D7BFC3B06172F5B131147818327364624A67064304C7BF5AF6D00B042401F3A1C2E71F6D5E0D9911979859F52D850AFC581C5A567C64E7D2F4AFAD009C6114C78F5AF7B006824D6D3E9A0F4E83F3976F781C3D9143334C4FE435945BD064E51F7075C605CC1CDAFFEB50E005608F84E4BAE0D36DA0B3DC6A444B2C80F3EB623F9607A8FFE93E20902F0E4CDA3B85FD73AAA6D00B042C0230C52F33CDB392463C5FAE8048A15080208B03E3AD750AD03801502C2E884E62CF09BB3786D5441697925050A040104D86ADDEBA71B0280DA1A98486774B5CFC64C79373CA7B0E4040509040138408EB89E00E08C10F023C1959F2EFC7E6D50F0ECC843D979E514201004E010E7C4436EA89DAE08005608684FC774D3CAFE4971ACEC0741000E34C02D75D33501C00A018BE99CACEC070802B0C93AB50D9D00E0CC00D04CA4D34959D90F1004E063EAC4C81BDC54335D1500AC10F06B719ACEAAC9CAFEA0E092398BD746B3B21F04013898BA33E2B76EAB97AE0B005608E84087D562657F042BFB4110800686B8B156BA3200582160129DD6B92BFBD3B258D90F7382C08B04019D6D74D3F7FEA6048026620B9DD7592BFB93F7B3B21F0401E6036D64BAED7B7F2302801502AE171974E2C0AFEC8F88DBCDCA7E8020A01375B6CCCFDC5C235D1D00AC10708FFABE99CECCCA7E8020000F9D174FB8BD3EBA3E005821E05F0C3256F603040178A8BF09B5D1880060858037E8D4FE59D99F5D58CCCA7E8020A0ABF9A6D44593024023B182CE6DCFD9D8ACEC0708022EB05D342500B833045C23F6D2C97DE7C57E93E259D90F10045C205BFC8F4935D1A8006085803B44059DBDC12BFBF7B0B21F2008B8E5EB4BF1BFA6D543E302801502FE24CED0E9BD5AD99FB9625D142BFB0182809B56FCFFC3C45A686400B042402BEBC133003C59D9DF9195FD806382403F82800F0D32B50E1A1B00AC10D093CE5FA7E3ACEC0708022E35CFE41A687400B042400883A08695FDC36745B1B21F707C10384C10F0CA2A75643C0180103087C1C0CA7E8020608C7071A5E9B58F00F0DF8B8356B1B27FCC9EC8B8DDFB994C0182808BED14CDA97D0480AA21E04A11CDCA7E000401D74A336DAF3F01C0F31070AD490705A995FDB317B1B21F200818214FFC805A4700A82D04DC2C725CBFB27FF2BB91ACEC0708028628177753E308009E8480BBAC0EC3CA7E000401FD4FF9BB9FDA4600A84F0878D0EA38AE59D9BF6B1F2BFB01181504D489AF7FA1A61100BC09010F8B637AAFEC1FADCEEC67653F80DA82409C0B8340A5F837B58C00D09010F01B1D43805AD9BF9C95FD00CC0C02EA98F70ED43002802F42C043E2A85E2BFBCB58D90FC0C420A03EF93F47ED2200F83204B470780860653F00D383C039D19A9A4500B06B61E0A74EEBF003D5CAFECC5C56F603B021081C38A44910382B9EA6561100EC0C010F382504B0B21F0041E0CBD5FE4F52A30800FE0801F78B4F58D90F80201070A7C4DFA84D04007F86805F8B23ACEC0740100858F13F29FE8F9A4400084408B8CF1F218095FD0008025F5FF82CFE482D2200043204FC4A94D8D5C1474F7E8795FD0008025FA5CE66F92D358800E08410F04371C8971DBC47FFC9710733724A995800E81604BAF599B0C3C6E2AFD65FB5A0F610009C14026E10F10D7EDD1F34A260F5C731894C240074B67EEB8E5D6D3B8764F8B8F8AB9B5A7F4ACD21003831045C2DD6787B7AD5D0917323B20B8B8F3379007083FC92B27353662F8F6AD5D127C7A9278BEF516B08004E0E014DC45BF5E9D8EDBA861ED89EB8976D7D005C292D33B7A2CFD0E9B10D581FB05134A3C61000740902433DE9D8C346CF8B28282D3FC72401C0ED22E353D29EEB165ADFF552F3C465D41502806E21E079EB78CAEA3AF58977576C8D65520060D6D702A5E7068F9813EB61F11F4E2D2100E81C021EB9F43AE1369D46E4C5EF3A7098C90080A996AEDC9668EDE5AFE9529F206A0801C02D670514AA8EDDA97758727A6EC1A74C00004CB76BDFA1DC765D461EAE668FFFA3D40E02809B42C0AD23272C5E5B505A7E9E810F009FCB292C39652D10BC687D50FA15358300E03AD2D96F159CE50F009798B364DD2A29FE3FA0561000DC1C02AE103319F000F0A5B5E23A6A0401C09420D05E70C63F0093A90BCE068B46D40502806921E07FC521260100062A167FA21610004C0E01CDC572260300068914DFA5061000F07910E82F381110809B5D10630527FB1100704908F8BD28629200E0429F88A798EB0900A83904DC64BD1E63C200E016BBC41DCCF10400D41D022E13E3983400B8C06C7125733B0100F50B024F8BA34C200034A4B6393FCF5C4E0080F721E04EB187C9048046D2C43DCCE10400343C045C2D1631A900D0C032D18CB99B0000DF0681EEE234130C00073A2B5E62AE2600C0BE10F04B6B452D130E00A7C8112D98A30900F0CF2E8141E214130F800052D79B4FE3953F010081592018C124042000F68987988B0900085C086824BA8A4F999000F8815A87344C34650E2600C01941E066B19AC909808DA2C44F9873090070661068254A98A800F8907AC3D84DBD71649E2500C0D921E07AB180490B800FA8EBCAB9BA970000CD82C023228B090C8017F2C53F994B0900D037047C534CB6B6EB30A901A8CB05314334670E2500C01D41E0416BDB0E131C809A1C100F33671200E0BE10D054BC21CE30D101A842CD09C3D9DA470080FB83C0CF441C931E00B15DDCCDDC4800803921A0B1784E64320102462AB12E18636B1F0100860681CB454F51CC840818E11331542D10660E2400005FEC1618CA91C2806B9D10A3C575CC792000A0A64384C2C449264CC0350BFCDE143731C78100004FEF169825CE3181025AAAB44E04BD8D390D0400787BE5F052EB70102655400F1FB2B21F0400F82A08FC4A6C6062051C6DA3B88F390B0400D81104FE20629968014789516393390A0400F82308FC43EC65E205026AB778823909040004E230A1F6DC3808F8DD21D186437C40008013EE18E8C6654380ED3244677119730F0800705A18F89358616D4162C2067C733DEF7AF1B87AEBC63C0302009C1E04BE2F4689322670C0EB237B27881F32A78000001D83C015E20591C8840E78BCB0AF8BB89A39040400B8250CB4104BACA34999E881FF3A6B1DB8F55BE60A1000E0E62070A318260A98F861B842F186F82E730308003029085C265A89280A010CA3FA7C6B751D3773010800303D0CFC42CCB1AE2CA540C0ADD7F1CE163F67CC8300007C3D085C27FA59FB9D291A7083C3A28FB896310E020050771068642D1A1C471880868AC44CF1174EEB030100685820F8A5081107282E70A82C6BDFFEC31CD8030200604F18F889182A76517410602A908E54D7653336410000FC1B066EB7D60CC45A47A6529460B72431440551C62008008033C2C0F7444FB18DBB08E043E745B4B590EF56C61A080080B3C3C00DA29375890A270FC29B93F9365AB75CDEC898020100D0330C7C4BB4B36E29FC8CE2861A9C14ABC4F36A3B2A63070400C07DA70FAAED8583AD4F78C7297CC62A162BC5006BE5FE958C111000007302C1E5D6E4AF76156CB13E05521CDDA7D2BA656F86784EDC41FF0701804600AA0682A6E277D665451B4419C5534B9F58CF6F987518CF35F46F800000D43714DC265A8AB1D60E83A314584751DB3F53C53CD159FC94D3F700020060D731C57759AF92A788181617FA956AEB70112A9E10D7D32F01020010C860708BF83FD15B4CB7DE161452B0BD5668B5A1FADEFE25F188F8019FEE010200A0D336C407C50B628C582E124589E1A7175EB056E227596D32CADA82F780684EDF010800809BC3C115E287E24F56F17B4DCCB20E30DAA7F97A830A6BE5FD47D6A7F8C1D6D7267F50ABF0D5EF4E1F000800006ADFAAF81DEB12A487C4E35621555F35BC2E268985628D88B0EE45509FAA53C441912E72AC2B6ACBC53171CA3AE2F6BCF5CFC7AC7F5764FDD974EBA29B14EB6D45ACF5BDBB3A2867BE9868851575F4F2B3E231EB2DC79DD6298C4D787680B3FD3F6A5B61BFA2D238BD0000000049454E44AE426082);
INSERT INTO `tbl_basicinfo` VALUES ('34', '9172016 - 3', 'Decastro ', 'Lara ', 'Urbina', '1999-09-17', '17', 'Female', '5\'1', '70', 'Esla dahodine', '', '090 952-13367', 'Without Philhealth', 'In - Patient', '10:55:22 AM', 'September 17, 2016', 0x89504E470D0A1A0A0000000D4948445200000200000002000806000000F478D4FA0000000473424954080808087C0864880000000970485973000085B6000085B601A9B9F3CC0000001974455874536F667477617265007777772E696E6B73636170652E6F72679BEE3C1A000031F04944415478DAEDDD777CD5D5FDC7F1028AA342D5FAABB6DA3A5A6B6DFD756855ACDDED4FADD6DA5A198228842943650B88124218612343866C1551A60C995964900442980964EF89826C02FC3EA77EB511336E6EEEF7DEEFF99ED71FCFC7C347A5989CEF39E7F3BEDF7BC6372E5EBCF80D00CED5B2C3F0A6E216F133F11BF198682DBA8A0122444C150BC52A112E768A54715864886C912BF245912811E5E288382A3E13272C65D69FDF2F12ACBF6FAD5826E68B6962AC785DF4B37E8E7F8A16E2367125CF0D703E1A01086C71BF4AFC48FC513C275EB50AAC2AE449A2585C101735F3A9154022C45231D9FADD3A5801E617E21AFA00400000DC5CE4AF170F8BCE6282F848ECB63E815F349C7A1B1125DEB602C2BFC5CFC5D5F41D800000E852E86F167F15BDC50CEBD5793145DE2B17ACAF2B541BCE1603C593EAAB10FA1A4000000255E89B885F5ADF7DAB4FAE3BACEFD129DCFEA1D62F6C10A1D61B83DBE897000100B0A3E0FF403C23C659AFAB4F50841DA7426CB11627AA0592778A46F45F800000785AEC9B8B3F8BC1D642BC228AABB6D45B998FADB5050F89CBE9E3000100F8A2E05F6115FC51D696B7F3144ED73A2E368921D6A24C02010800804105BF91B8D75A54A68AC1490AA3B14E585F1BBC267EA7CE5B608C800000B8ABE8DF2EBA5807D9B0F50E35516170A3E8256E65EC800000E8B94AFF8FD6E9781914367829C53A65F101161482000038FBBBFC27AC6D7965142FD87060D11CEB2C82AB1873200000812DFACDAC2D5FEAA8D9631429F8F1AB8235D6C98E373216410000FC53F46F1041D6E534A7294608B04A6BAB617BEE36000100F07DD1BFD2FAA4BFC19A70293C70EAAE82F7C4DFD962080200D0B0C2FFA098293EA1B840336A1DCA74757D3363190400C0B3A27FB37572DB418A085C22538C147733C6410000BEFE8ABF8DF55D2A27F1C1CDE2C5F36AD70A631F0400985CF8EFB15EF17F4A6180815F11A88B8B6E672E000100A614FDC6E21F622B4500F8CF1BAF75D619168D99234000801B0BFFB7441F4EE6036A5D2B30486D7565CE0001006E28FC778969E2332678C023EA7C8B456A170C73080800D0ADE8AB1BF7FE66EDDBBFC0840E782D523CCABC0202009C5EF82FB76EDD4B63E2067C6AA7788675022000C069855F5DC4F3A2C861A2066C952A3A72D220080070C2FEFDDE229F8919F0AB5CF192B89AB9080400F8B3F05F6DADE82F62220602AA540C55BB6C989B4000809D85FF1A31509430F1028E7254BCCE8D842000C0D785BF991822CA996801472BB1BE966BCADC0502001A52F82F133DF8C40F6879A8503BB52597B90C0400D4B7F83F65AD38663205F4B55B3CCE9C0602003C29FCF75B878F307902EE3A50E821E6381000505DE1BF5DBCC7C97D80ABAD143F65CE030100AAF05F27C68B334C8E80112AC59BE25AE6400200CC3DB6B7AF38C28408187B864047160A12006056F1FFBDD8CF040840C4897B991B09007077E1BF41CCE37B7E0097382F668AEB992B090070DFF5BC1D39C807401DCAAD1B3DB9759000001714FF9F8A28263600F590201E600E250040CFC27F951825CE329901F082FAAAF02DD19C399500007D8AFFDFACA34099C400F8E2EAE147995B09007076E1FFB658CA8405C0066F73ED300100CE2CFE4F882226290036CAE76E0102009C7555EF1C2626007EB4409D22CA1C4C0040600FF4E1BB7E008150289E642E2600C0BF85FF0AEBFCFEF34C4200026C0907081100E09FE27F2FC7F8027018B5FEE8AFCCD10400D853F82F13C3D8D70FC0C1C709878A26CCD90400F8AEF8DF2AE29960006860BBF83E733701000D2FFE4FB6E4CA5E007AA9104F31871300E0FD2BFF306EEE03A0B129A229733A01009E17FF9B453493070017D8297EC4DC4E0040DDC5FF1151CAA401C0458E89B6CCF10400545FF81B8B60F6F60370B1B9EA1C13E67C0200FE5BFC6F145B991C001840ED68FA2E733F0180E2FFF971BE854C0A000C5220EEA70610004C2EFE5D38D80780A14E89F6D40202806985BF8998C4040000C3C7A93550D406028009C5BFB958CFA007802F6D10D7522308006E2EFE7770910F00542B4DDC45AD2000B875B15F39831C006AF4A9789C9A41007053F1EFC4623F00F0883A0BE5156A0701C00D87FB4C60400380578B031B514B08003A16FF6F8A750C6200F0DA3BE2726A0A0140A7E2FF6DEBB42B06300034CC66D18CDA4200D0A1F8DFC24A7F00F0A9647113358600E0E4E27F97C861B00280CF65891F536B08004E2CFEF7B5E41A5F00B093DA4ADD829A43007052F1FF73CBCFEFBB66800280BD4E88BF537B08004E28FE4F8BD30C4A00F09B4AD1811A44000864F1EF6C7544062400F8D705D1855A44000844F11FC4000480808780EED42402803F8BFF30061E0038462F6A1301C01FC57F08830D001CE7656A1401C0CEE23F904106008ED58F5A4500B0A3F8F763700180E30DA46611007C59FC5F66500180368650BB0800BE28FEBD184C70B833AD3A061F691D34A2A06DE790F4F6DD47ED0BEA357657B73E13E27B0F9ABA7DC01B6F450E1B3D2F62D4A477C227CFFA3062F6A2B5514B3EDC1CB3627DF40E45FDB3FADFD4BF537F46FD59F5FF51FF5FF577A8BF4BFD9DEAEF56FF0DF5DF52FF4DDA1D0E378C1A46006848F1EFCE2042A04F3D6BD775645ACF01936343272E097F67F9969898C47D07F71DCA2A48CF29389257527AA6A8BCE26220A8FFB6FA19D4CFA27E26F5B3C9CF18A17E56F533CBCF7E92E787001B442D23007853FCBB587B4C1944B05DEBA0E0A28E3DC7EE1A387C56E4B4B92B23D66D894FDC9B96995F585671215005BEA1D4CFAE7E87B59BE392D4EF24BF5B94FC8EC9F2BB16F3CCE1479DA9690480FA14FF0E147FD8E47450AFB0A490F18BB72DFE60D3F6ED897BF767E5177DA66B91F796FA9DB727EC3D206D1013327E5184B4C92EBE56808DC7063F4D6D23007852FCFFCEF1BEF0A5369D46E40C0A9E15BEEAE3ED3B720A4B8E9B56EC3D955D587C62D586ED89EA4D81B4591E7D07BE0CDEE2CFD43802406DC5BF45CBCF6F9A62C0A0214E767E695CC2B4B92BC393F71FCEA4B87B67D7BE43D96FCE5911256D99246D7A8A7E85065237B6DE47AD23005457FC7FDCF2F3BBA61928A8B7673B85640E0E9913BE76735C426E51C9490AB86F499B9E5AB33176E7E0117322DB740AC9A6CFC14BA5E22E6A1E01A06AF1BF4964313850BF57FB21995367AF08DF7330238722ED5FBB0FA4E74D99BD3C8A30002FE4885BA87D040055FC9B896406053C15D42B2C71F5C731F1856515E729C681DE69507E61D586ED09EAAC02FA26EA61BFF83601C0ECE27FB9D8CC608027FBF1FB0D9B199198929A4AE175A684DDA987FA0D9B11C5F903F050BCF82601C0CCE2DF48BCC320401DFBF30BC64D7B7F4B7A6E411945560FE93905E5E3A62DDDA69E1D7D187558271A1300CC0B00E3E8FCA849FBEEA376BFB7726B544169F9198AAA9E0A4ACBCEBEB7626BB43CCB14FA346A3181006056F17F854E8F1A0A7F4A547C4A3205D45DD4332508A0169D08006614FFC7C5793A3C2EF1E9CCF9ABB7159655545230DDBA60B0A2523D63F5ACE9EFB8C459F17B0280BB8BFF5D0C7E5CAA47FFC9DB5333728B28926650CF5A3D73FA3E2EA1CE81B98300E0CEE27FAD48A393E3CB7DFC4123723FDA141B4F5134937AF6AA0F301670C9F6C0E604007715FFC662039D1B96736F8C991FCEB9FC507D40F505D5271817B0AC174D0800ACF887CB3CDF7DD4DE1DC907D2287EA84AF509D5371823B04C2200B8A3F8B7A7334319396171B8BAA39E82871A16095E089DB8389CB1024B170280DEC5FF7E6E118338B368D9C6288A1C3CB1F0FD8D6A81E019C60D3B03DCBE33C0CDC5FFBB8293C00CD7AA63F091CD5149BB286CA88FCD9149C9D2773E610C19AF50DC4800D0ABF85F619DF34C0736FAB6BE1159BBF61D4EA7A0C11B3BF71ECA943E94C35832DE56B71E17ECD60030974E6BF862BF1747EF4ACFE1FC7E34CCE1ECFC72E94B7B1853C60B2600E851FCDBD259CDD673C09488BC92D2931430F8426E51C9A99E0326C730B68CA64E8F7D8400E0ECE2FF23718CCE6AAEE163177C2C93F6790A177CBD43E0F5CFCF0B609C99AB54DC4C007066F16F2A76D249CDD5F7B5199B2956B0539FA1D33942D86CD1E2320280F302C0143AA7B9827A85EDE0EA5ED82DBFA4EC5CC75E63931973460B230038ABF83F45A73457DBCE216959F945472850F0878CBCC2A3CF760EC964EC19EB82789200E08CE2FF7D5141A734769F7FC9DEB4CC2C0A13FC29E56046BEF4BD72C6A0B18E885B0900812DFE4D04DFC999EB44F48E3DBB29480884F0D8E4039C346AB478DDD703E81E0042E984E66ECBF9604D4434850881B474D5B604EB953063D24CC308008129FE7FB5F666D2090D14F6E65256FCC311C64C79379A3169F47D01F71200FC5BFCAF1745743E33B5EF362AA5B0ACBC92E2032728282D3F2F7D3295B169ACFDEAF8790280FF02C0123A9DB937FB25EC3E7880C2032789DBB93F5DFAE639C6A7B1C61300FC53FC9FA4B3996BC4F845BCFA872305872DE4AB00B38F0AFE3D01C0DEE27F9D753D231DCE40CF760A49E78C7F38F8CE8033D247B93DD05CEA6C88660400FB02C0023A99B9876F6C89DE9944A181936D0C4FD8CB5835DA1C02803DC5FF713A97B9FA0F9BB98D02031DF47D6D462C63D6684F10007C5BFCBF25F2E958C69EF65794C951BFD0447A6EC131E9B3658C5D63A91D6ADF2600F82E00BC4DA732D7D4D9CBB75058A093496F7DC009A5665B4A00F04DF17F94CE64F4A7FF8A9CC2E2631415E8242BBFE8A4F4DDA38C61A33D46006858F16F2E72E948E61A396131DBFEA0A511E316B12DD06C19E22A0280F701E02D3A91D997FD1CCEC92FA1984047A999B9EAC6B8D38C63A38D24007857FC1FE0920DB30D0A9EB59542029D0D7CE3AD18C6B2D927978A9F1000EA57FC1B8B043A8FD1CEED4DCDCCA4884067C9FB0FE7736999F1B61100EA1700BAD069CCD66BE094480A08DCA0E780C93B18D3C66B4F00F0FCA6BF723A8CD936472525523CE0061F8727EC614C1BAF441D654F00A83B00CCA4B318BFF5AF98EB7EE1A6EB82A54FF3A1066F11006A2FFEF7F27D19060E9F154EE180CB1603723010D4A2F6160480EA8B7F23114727C1E6A8A49D140DB8EA92A088C414C636C46ED18400F0F5001044E740AB8EC125BCFE874BBF06E07E00283D08005F2DFED78A523A06060E9F1541C1802BBF06183E2B8A310EABD6352700FC3700BC49A7C07F5EFF472625532CE0469B22137733C661194500F8BCF8FF5454D221A08EFE2D282D3B47B1803BBF06283BA7FA38E31CE294F83E01A0C3F0957406281D7A8EE1D33F5CAD438F312C06C41716191D00A4011EA213E00BC1610BB75124E066C3C72E8864ACA3CAB6C07B4D0E000C067C69D586ED711409B8D98A7551498C7538E59E804016FFC779F8A89A86D3730A4A291270B3B4ACDC4F18EBB8C4DF8D0A00D6A13FAC88C597DA741A9141818009A4AFE731E651C50171994901A01D0F1D55F51E3495DBFF60845E03A7703B202EF5A21101407ED1A62293078EAA464D7A6733C501261839617134631ED5DC16D8CC8400D09B878D4B2D5AB68913006184F9EF6D8867CCA31A435C1D00E417BCC64A3A3C6C7C45786C321700C1089BA392F633E6510D7565F4356E0E00AFF390519DB4CCDC7C8A034CB0EF505639631E3518E8CA0020BFD8B7C4511E30AAF1994C8CE7290E30416159B9EAF36718F7A8612DC0D56E0C004378B8A8610B603A8501866D05CC67ECA3067D5C150054A2E1BA5FD4A46D979107280A3089F4797642A12645E24A3705809778A8A849FBEEA37653146092F6DD46A532F6518BDEAE0800F28B5C2E7279A0A8F116C01E6392280A30C90B3DC6EC63ECA316EA2BA22BDC10003AF230519B4EBDC3E2290A304950EF308E4247C04F07B4BBF83716BCEA42ADBAF5991043518049BABE326127631F75C8516FD0750E00CFF01051979E03A644511460921E03262730F6E1812E3A0700522EEAF4CA9069E1140598E4E5C16FC631F6E101F506BD917601407EE8477978F0C48037DEDA46518049FA0F9B19CBD887871ED3310044F2E0E089BEAFCDE00D008CD267E8F418C63E3CB44EAB00203FF0833C3478AA7BDF89B114059844FA3C6B00E0A90BE24E9D02C0221E1A3C3E07A0E798648A024CD2A1C79814C63EEA618A1601407ED01BC4691E183CD5AE6BE8418A024C227D9EEDD1A80F75915E331D02C0201E16EA170046A651146056001899C6D847A08F07B6E3E01F2EB90001002000C0B7D27CBD25D0D701E0091E120800000100CEDF12E8EB00B08E070402004000802DD63B3200C80F76BB38CF030201002000C0B62D813F76620018CBC30101002000C056931C1500E407BA4294F1604000000800B05599AF6E09F45500789E870202004000805F3CEDA40010CF030101002000C02FD6382200C80F72370F030400800000BF39276E74420018C9C30001002000C0AFFA39210070F21F0800000100FEB52FA001407E80DFF010400000080008885F0732004CE70180000010001010D3031200D43E44F6FE8300001000103047D4393C8108007FA7F1410000080008A856810800EFD1F02000000400E8794190B7C5FF1A718286070100200020A02AC50DFE0C00ED697410000002001C21C89F01E0631A1C04008000004758EB9700A08E1FB45E39D0E8200000040004DE69D1CC1F01A0338D0D0200400080A3B4F647005843438300001000E0284B6D0D00F21FB84A9CA4A14100000800709463F53D14A8BE01E0491A190400800000477AC2CE003087060601002000C091DEB62500C85FDC4814D1C020000004003892BA9FA7891D01E0011A17040080000047FBA31D012084860501002000C0D1A6DA110052685810000002001C2DC3A70140FEC25B69541000000200B470BB2F03402F1A1404008000002D74F16500D848838200001000A085653E0900F21735E5F43F1000000200B451AEB6EEFB2200FC8EC60401002000402BF7FA2200BC46438200001000A09581BE08005B68481000000200B4B2A9410140FE82CBC5091A120400800000ADA8B57B573424003C4C238200001000A0A53F3724000CA1014100000800D0D2A88604804D342008000001005A4AF02A0058DFFF1FA7014100000800D0D279D1CC9B00F0108D0702004000803BD701D416005EA5E14000000800D0DAABDE04808F69381000000200B4B6A25E01409D212C8ED2702000000400682DBFBE01E04E1A0D040080000057F85E7D02406B1A0C040080000057F8677D02C0581A0CFE0B00A107290A302B00841E64ECC38F46D72700700110FCE5CCFAAD3B92280A3089EAF3AAEF33FEE1275BEB13002A6830F8E3908A77576CDD4E41808954DFB70E6A612E80DDD4A2FE46750600F943B7D158F087E96FAFDA462180C9D418602E809FDCED4900F8370D05BB05872DDC4201002AFE33169813E0072F781200426928D8A96D97916905A5E5E798FC818A8B6A2CC89838C4DC009B4DF724006CA0A160A30B5BA277B2E80FA8627354523273036C16E9490028A1A16097DE83A64630E1035FD76BE09418E608D8A8B4D600207FE0161A0976AE444DCDCC2D60B207BEEE607A4E714BAE6087BDBE5D5B00789206825D42C62FDAC4440FD4BA20308AB90236FA6D6D0160200D04BBECDC7BE800933C50B31DC90732992B60A32EB50580D934106C5AF9CF71BF8007DA760EC962CE804D26D61600C26920D861CC94773733B903751B35E99D68E60CD864436D01209F06821D92F71FE6C63FC0038929A939CC19B04976B50140FEC5D56A8F360D045F6BD3694406133BE039193305CC1DB0E31C16F1CDEA02C0CF691CD821A8575802933AE0B98EBDC6A63077C026F7551700B80300B6E833743A87FF00F5F0CA90691C0A04BB3C575D00789586811D464E58CCAD7F403D848C5F14C9DC019B84561700DEA6616087398BD74632A9039E9BBDE8237602C02E1F54170038810AB658B331963500403DACD91893C8DC019BC45717008A6818D8615364E26E2675C0736ACC3077C026F95F0900F23F5C43A38000001000E07A95A249D500F00B1A05040080000023DC5235003C46838000001000608416550340071A040400800000233C53350070060008000001006678A56A00984C8380000010006084F15503C0521A040400800000232CAD1A0022681010000002008CB0BD6A0048A5414000000800304276D500F0290D02020040008011CE8AC6AAF85F4963800000100060941B5400B88D860001002000C0283F5201A0050D01020040008051EE5301E09F3404080000010046F9B30A005D690810000002008CF2B40A00FD680810000002008CD2510580D7690810000002008CD2470580B1340408000001004619AE02C0341A020400800000A34C5201603E0D01020040008051E6AB00B08C860001002000C0282B5400584B43800000100060946D2A0084D31020000004001865A70A00093404080000010046495501603F0D010200400080510EA900904D4380000010006094741500CA680810000002008C92A902C0091A020400800000A36411004000000800304F8E0A0047690810000002008C92A702C0111A020400800000A314B008100400800000F314A900504C43800000100060946215000A6808D869E5FAE81D4CEA80E73EDA149BC4DC019B95AA00904343C04E6FCE5D19C1A40E786EE1FB1B63983B60B3721500326908D86948C8DC702675C07313677E10C5DC019B1D5101E0300D013B757D65421C933AE0B961A3E7453377C066152A00A4D210B053DB2E235399D401CFF5E83F3991B90336CBE53640F8C33199D42E30B103752B2CABB8D8AA637039F3066C76500580141A02763B989193CBE40ED42D61772A37B4C21F125500D84543C06E13672CDBC2E40ED46DC6BCD57CFF0F7F08570180EF9A60BB369D46641696559C6782076AD7F9E5719C01007F58AB02402C0D017F58BF75473C133C50B35DFB0EAB73592E305FC00F96AA00B08186803F74EF3B3186491EA8D9ABC1B3D9FF0F7F99AB02C0BB3404FCE4DCC18C9C02267AE0EB32F20A8FC91839C13C013F99A202C0341A02FE121CB6602B933DC0E13F08B8501500426808F8F32DC0B698E414267CE0BFB627EE3D2463A392F9017E34580580BE3404FCA975D088FC8CDC82234CFC40C5C582D2B2CA765D430F3137C0CF5E5201A0030D017FEBD677223B02003172C2625EFD2310825400788A864020CC98B78A6B8261B4F9EF7DCC366C044A2B15007E474320404E47C4EDDE4B218089D66E8EDBA9D6C4300F20401E5701E01E1A02017472E9CA6DB1140498645364E26EE9FBC719FF08A0FB5500B8998640805D089DB824BCB08C1B03E17E33E7AF8EE1933F1CE0161500AEA221E0043DFA4F8ECD2D2A394991801BE5979456F67F7D661C631D4EF8D0252EFBC6C58B175508384D83C0099EEB167A202BBFE8330A06DC64C3B61D7BDB761999C518874394A8DAFF450028A441E014EFAF0E674D005C61DFA1ACA21EFD27EF605CC36176570D00FB69103845DFA1D3A3281ED0D9E6A89D7B7B0F9A1ACBDB5538D486AA0120820681734E0A0C2EA2884047AB366CDFF96CE7906CC6311CEEEDAA0160010D0227D9B1FB601A0505BA69D7752447FA420723AB068037681038C9C4991F845350A093F8E403E98C5D68A267D500F03C0D0227E9D873EC4E8A0A74F2FAE8F9918C5D68E25F5503C0EF691038CC99ECC262B603420B8565E5E75B070517336EA189165503C0F7691038CDCAF5D171141768B2CF3F99310B8DDC5A3500341667691438C9C037DEE2B64068E1E5C1D3B63366A191A65F06002B04B080058ED22668440EC5054E97535872B22517FB401FE55FD4FDAA0160330D03A7D9B5EF703A45064EB6E4C3CD318C556824B1BA0030878681D3BC3977C5368A0C9CACF34BE39218ABD0C8E2EA02C0101A064E2393EB0E8A0C9C2A2D33B754FA692563151A195A5D00684BC3C0814E65E41556506CE04453E7AC60EF3F74F3EFEA02C043340C9C68E682D57C0D00477AAE5BE841C62834F3B3EA02C04D340C9C4826D9BD141B384DD29EB40CC6273453F9C516C04B034023719206821325A6A4A65274E0248343E6708B2A7473E88B9AFF950060850056B3C2915E0B7D7B2B45074E919157F8297BFFA1A135B50580B934109CA855C7E0D282D2B233141F38C184E9CB58FC071D85D516007AD14070AA15EBA263293E08B4FC92B2735CFC034D05D516007E4B03C1A9BAF599400040C02D5AB63196F1084DFDA6B600D05C5CA091E050670F65E59550841048EDBA86A63116A1A9EB6A0C005608606B0B1C6BCAACE52C0644C07C1C9EB08771084D955C5AEFAB0B00CB69283855DB2E23D90E8880E9F2F2F89D8C43682AD29300308C8682936D4FD8BB8762047F4B4C49CD66FC4163533C09004FD25070B27EC366465090E06FFD86CD60F11F74D6D69300F07D1A0A0E772A2D33B798A2047F49CDCCFD44FADD69C61E34F6C33A038015022A682C38D9F0B10BB820087E133A71490CE30E1A2BABAED6D71400B6D16070B8A359F94547294EB05B4E61C999561D838F30E6A0B175F5090013693038DDF8E9EFF31600B69B3A7B39DFFD4377AFD727003C4F83C1E9E45359495E71E9298A146CBBF427B7E084F4B34F196FD0DCA3F509003FA6C1A083D98B3E8AA450C12EC1610BF9EE1FBABB70E90980B506002B0414D17070BA369D46641796955752ACE06BFB0F6797AB1D278C33682EADA63A5F5B00789F86830EDE5BB9358682059FEFFB7F6D461CE30B2EB0C89B00D09386830EDA750D3D48C1822F25EC3E98237DEB3CE30B2ED0D39B00700F0D075DACDB129F44E182AF74ED338133FFE116BFF626003412E5341E74F0C28BA353285CF085CD514907185370CBA9A9E2F27A07002B04ACA401A18B15EBA2E3296068A8E75F1C4D00805BC4D456E3EB0A00AFD080D0C5B39D43320A4ACBCF51C4E0AD656B2292184B7091110D0900F7D280D0C9AC859C0B00EFE49794554A88CC611CC1457ED79000D058700A16B43A1D30BBA0F838050DF5F5D682351CF90B3739262EF33A005821601D0D099D844E5CC21D01A897ACFCA293121ECB183F7091D575D5774F02C0401A129A399E9A915B446183A75E0D9ECD91BF3066FF7F7D02C083342474D36FD80CD602C0235BA377EEB7CE4B67ECC04DEEF44500B84C7DA2A231A199CAA43D69872970A84D6E71E999673B8764335EE0325975D5768F0280150256D3A0D04D9797C7EFA0C8A18EDBFEA2192B70A1D9BE0C0041342874F4FEEAF0ED143A542736695FBA7A53C438810B3DE3CB00F09D965C8C013DB7059666E4165450F05055416959E5735D430F3146E042AA565FE7B30060850056C9424B2F0F7E338AA287AAC64D5BCAAB7FB855BCA775BD3E0180ED80D0D6DACD71AC07C07FECDC7B489DF6779A7101138FFFF53600DC45C34257AD8346E46517167F4601345B6159F9C5177A8CD9C79880A9C7FF7A1500AC109046E34257AF06CFE68440C3CD98BF9AAF32E166E5751DFFDB900010460343E7C531E131C9C9144233ED4BCB2CE64C13B8DC9CFAD4F4FA0680876960E8ECD9CE21E97925A5A72888E6E9FCF2B85D8C01B8DC23760600753B60298D0C9D8D18B7680B05D12C13677EB09DBE0F5EFF3720005821601E0D0DCD9D8DDBB57F3F85D10C1B2312F772E00F0C30B7BEF5DC9B00F0140D0DDD3DD735747F4169F9390AA4BB1D389C5DD6AA6370397D1E0678D41F01E06A7192C686EE26CC58C657012E965F525AF9FC8BA30FD0D761808AFABEFEF72A00582160150D0E1738B9FB407A3AC5D29D5E1D313B963E0E43BCED4D2DF736003C4383C3155F05740BDDC7AE00F759F2E1E644FA370CF2983F03C015E2088D0E3718F0C65BE1144DF7884F3E90C5D7943088AAC597FB2D00582160260D0FB7904F8C5C1BEC02197985279EED1C924B9F8641E6795BC71B12005AD0F07091E38929A91914519DCFF9AFB8D8BDEF440EFB81691EF77B00E06E00B8F094C0CCFC9232B6066A6AEAECE52CFA83693EF1F6F5BF2F02C0501E00DC2423AFF028C5544FBD074DDD411F86616637A486373400FC405CE0218000000200E077F7072C005821601B0F010400100000BF4A6968FDF645007881070102000800805FF5764200B8A625776C8300000200E02FA7C475010F00560858C4030101000400C02F96F8A276FB2A00FC95070202000800805FFCD14901A0B1E0F42D1000400000EC75C81775DB67018033014000000100F08B414E0C00FF632D4CE0018100000200E07BE7C48D8E0B00560898C7030201000400C0162B7C59B37D1D007EC9030201000400C0168F3B360058212092870402000800804FA985F68D9D1E009EE6418100000200E053037D5DAFED08004D44360F0B04001000009F382ABEE5F800608580013C3010004000007C629C1DB5DAAE00709D38C1430301000400A041CE8A5BB40900560898C9830301000400A04116DA55A7ED0C0077F3E0400000010068907BB40B005608D8C4C30301000400C02BEBEDACD1760780277880200080000078E54F3A078046229987080200080040BD24DA599F6D0F005608F8270F1204001000807A69E58600C05B0010004000003C97A10ED5D33E00F0160004001000807AE9E98FDAECAF00C05B001000400000EA562CAE764D00E02D0008002000001EE9EDAFBAECCF00C05B0010004000006A96239ABA2E00F0160004001000805A05F9B326FB3B00F016000400100080AF4BF3C7CAFF800500DE02800000020050AD36FEAEC7810800BC058063E515979EA6986A1B00E2E9C3D0548AAA8DAE0F00BC0580839DA490EAABFFEB3363E8C3D0D49381A8C5810A00EA2D40020F1D4ED23A28B89842AAAFE0B085D1F46368282E1075386001C00A010FF3E0E1246DBB8C3C4C21D5D7A4991F1000A0A3BF181700AC10F03E0F1F4ED1A977581285545F6FBFB33E967E0CCD6C0D640D0E7400B8559CA213C00982C316865348F5B57EEB8E14FA3134D3C2D800608580503A019CE0C38F22E329A4FACAC82D382ECFF1027D199A5819E8FAEB8400708D28A23320D0F61FCE2EA490EAEDD9CE21D9F4656840BDF9BEDDF800608580203A0402A94DD0883C0AA8FE5E1E3C2D8EFE0C0D0C7742ED754A00682C76D12910286F8C5D104101D5DFDC25EB080070BA2C711501E0AB21E00F740C044ADCAEFD691450FDA5E7161C95E779863E0D07FB9753EAAE630280150296D339E0F7FDFF9D43D2299EEED1BDDF44EE0480536D7452CD755A00B8439CA693C09FA6CC5ECEEB7F1759BE36923B01E04467C55D0480DA43C0583A0AFCA555C7E092DCA212EE007091FC92B233F25C8BE9DF709830A7D55B270680E66C0B84BFBC3977651445D37D66CE5F1D41FF868314A82DEF0400CF42C0D37418D8AD755070917CFAE7FA5F77BE0538DBA6D3883CFA391CA29D136BAD23038015023EA4D3C0E693FF122996EEB5F0FD8D6C0984134439B5CE3A3900DC248ED079608757864C8BA548BA5B4169F985E75F1CBD9FFE8E00AA14BF20007817023AD081E0FB57FF230A33F30A3FA348BADF9ED48CC2561D871FA3DF83857F9A05002B046CA213C1874E6F89DEB98FE2688E77966F49A0DF23000E8A2B09000D0B00B789E37426F8C0F9656B22765014CDD3F7B519B1F47FF873AE6919E0AB7E5D1100AC10F0121D0A0D3573C11AB6FC99BB2BE05C9797C7EF641C8057FFFA0500755910091EDEBA307EFAFB9CF66738B5E5B343CF317B180F30FDD5BF5601C00A017773C907BC7072E9CA6DACF8C77F64E5179D68DF7DD441C6054C7EF5AF5D00B042C0303A18EA73CC6F547C0A0BFEF015398525A77A0D9CC27D0130F6D5BFAE01E072914227435DBAF59D187F3023A79882879A4C9EF561B4B54F9B3103A35EFD6B1900AC10F02BBE0A408D7BFC3B06172F5B131147818327364624A67064304C7BF5AF6D00B042401F3A1C2E71F6D5E0D9911979859F52D850AFC581C5A567C64E7D2F4AFAD009C6114C78F5AF7B006824D6D3E9A0F4E83F3976F781C3D9143334C4FE435945BD064E51F7075C605CC1CDAFFEB50E005608F84E4BAE0D36DA0B3DC6A444B2C80F3EB623F9607A8FFE93E20902F0E4CDA3B85FD73AAA6D00B042C0230C52F33CDB392463C5FAE8048A15080208B03E3AD750AD03801502C2E884E62CF09BB3786D5441697925050A040104D86ADDEBA71B0280DA1A98486774B5CFC64C79373CA7B0E4040509040138408EB89E00E08C10F023C1959F2EFC7E6D50F0ECC843D979E514201004E010E7C4436EA89DAE08005608684FC774D3CAFE4971ACEC0741000E34C02D75D33501C00A018BE99CACEC070802B0C93AB50D9D00E0CC00D04CA4D34959D90F1004E063EAC4C81BDC54335D1500AC10F06B719ACEAAC9CAFEA0E092398BD746B3B21F04013898BA33E2B76EAB97AE0B005608E84087D562657F042BFB4110800686B8B156BA3200582160129DD6B92BFBD3B258D90F7382C08B04019D6D74D3F7FEA6048026620B9DD7592BFB93F7B3B21F0401E6036D64BAED7B7F2302801502AE171974E2C0AFEC8F88DBCDCA7E8020A01375B6CCCFDC5C235D1D00AC10708FFABE99CECCCA7E8020000F9D174FB8BD3EBA3E005821E05F0C3256F603040178A8BF09B5D1880060858037E8D4FE59D99F5D58CCCA7E8020A0ABF9A6D44593024023B182CE6DCFD9D8ACEC0708022EB05D342500B833045C23F6D2C97DE7C57E93E259D90F10045C205BFC8F4935D1A8006085803B44059DBDC12BFBF7B0B21F2008B8E5EB4BF1BFA6D543E302801502FE24CED0E9BD5AD99FB9625D142BFB0182809B56FCFFC3C45A686400B042402BEBC133003C59D9DF9195FD806382403F82800F0D32B50E1A1B00AC10D093CE5FA7E3ACEC0708022E35CFE41A687400B042400883A08695FDC36745B1B21F707C10384C10F0CA2A75643C0180103087C1C0CA7E8020608C7071A5E9B58F00F0DF8B8356B1B27FCC9EC8B8DDFB994C0182808BED14CDA97D0480AA21E04A11CDCA7E000401D74A336DAF3F01C0F31070AD490705A995FDB317B1B21F200818214FFC805A4700A82D04DC2C725CBFB27FF2BB91ACEC0708028628177753E308009E8480BBAC0EC3CA7E000401FD4FF9BB9FDA4600A84F0878D0EA38AE59D9BF6B1F2BFB01181504D489AF7FA1A61100BC09010F8B637AAFEC1FADCEEC67653F80DA82409C0B8340A5F837B58C00D09010F01B1D43805AD9BF9C95FD00CC0C02EA98F70ED43002802F42C043E2A85E2BFBCB58D90FC0C420A03EF93F47ED2200F83204B470780860653F00D383C039D19A9A4500B06B61E0A74EEBF003D5CAFECC5C56F603B021081C38A44910382B9EA6561100EC0C010F382504B0B21F0041E0CBD5FE4F52A30800FE0801F78B4F58D90F80201070A7C4DFA84D04007F86805F8B23ACEC0740100858F13F29FE8F9A4400084408B8CF1F218095FD0008025F5FF82CFE482D2200043204FC4A94D8D5C1474F7E8795FD0008025FA5CE66F92D358800E08410F04371C8971DBC47FFC9710733724A995800E81604BAF599B0C3C6E2AFD65FB5A0F610009C14026E10F10D7EDD1F34A260F5C731894C240074B67EEB8E5D6D3B8764F8B8F8AB9B5A7F4ACD21003831045C2DD6787B7AD5D0917323B20B8B8F3379007083FC92B27353662F8F6AD5D127C7A9278BEF516B08004E0E014DC45BF5E9D8EDBA861ED89EB8976D7D005C292D33B7A2CFD0E9B10D581FB05134A3C61000740902433DE9D8C346CF8B28282D3FC72401C0ED22E353D29EEB165ADFF552F3C465D41502806E21E079EB78CAEA3AF58977576C8D65520060D6D702A5E7068F9813EB61F11F4E2D2100E81C021EB9F43AE1369D46E4C5EF3A7098C90080A996AEDC9668EDE5AFE9529F206A0801C02D670514AA8EDDA97758727A6EC1A74C00004CB76BDFA1DC765D461EAE668FFFA3D40E02809B42C0AD23272C5E5B505A7E9E810F009FCB292C39652D10BC687D50FA15358300E03AD2D96F159CE50F009798B364DD2A29FE3FA0561000DC1C02AE103319F000F0A5B5E23A6A0401C09420D05E70C63F0093A90BCE068B46D40502806921E07FC521260100062A167FA21610004C0E01CDC572260300068914DFA5061000F07910E82F381110809B5D10630527FB1100704908F8BD28629200E0429F88A798EB0900A83904DC64BD1E63C200E016BBC41DCCF10400D41D022E13E3983400B8C06C7125733B0100F50B024F8BA34C200034A4B6393FCF5C4E0080F721E04EB187C9048046D2C43DCCE10400343C045C2D1631A900D0C032D18CB99B0000DF0681EEE234130C00073A2B5E62AE2600C0BE10F04B6B452D130E00A7C8112D98A30900F0CF2E8141E214130F800052D79B4FE3953F010081592018C124042000F68987988B0900085C086824BA8A4F999000F8815A87344C34650E2600C01941E066B19AC909808DA2C44F9873090070661068254A98A800F8907AC3D84DBD71649E2500C0D921E07AB180490B800FA8EBCAB9BA970000CD82C023228B090C8017F2C53F994B0900D037047C534CB6B6EB30A901A8CB05314334670E2500C01D41E0416BDB0E131C809A1C100F33671200E0BE10D054BC21CE30D101A842CD09C3D9DA470080FB83C0CF441C931E00B15DDCCDDC4800803921A0B1784E64320102462AB12E18636B1F0100860681CB454F51CC840818E11331542D10660E2400005FEC1618CA91C2806B9D10A3C575CC792000A0A64384C2C449264CC0350BFCDE143731C78100004FEF169825CE3181025AAAB44E04BD8D390D0400787BE5F052EB70102655400F1FB2B21F0400F82A08FC4A6C6062051C6DA3B88F390B0400D81104FE20629968014789516393390A0400F82308FC43EC65E205026AB778823909040004E230A1F6DC3808F8DD21D186437C40008013EE18E8C6654380ED3244677119730F0800705A18F89358616D4162C2067C733DEF7AF1B87AEBC63C0302009C1E04BE2F4689322670C0EB237B27881F32A78000001D83C015E20591C8840E78BCB0AF8BB89A39040400B8250CB4104BACA34999E881FF3A6B1DB8F55BE60A1000E0E62070A318260A98F861B842F186F82E730308003029085C265A89280A010CA3FA7C6B751D3773010800303D0CFC42CCB1AE2CA540C0ADD7F1CE163F67CC8300007C3D085C27FA59FB9D291A7083C3A28FB896310E020050771068642D1A1C471880868AC44CF1174EEB030100685820F8A5081107282E70A82C6BDFFEC31CD8030200604F18F889182A76517410602A908E54D7653336410000FC1B066EB7D60CC45A47A6529460B72431440551C62008008033C2C0F7444FB18DBB08E043E745B4B590EF56C61A080080B3C3C00DA29375890A270FC29B93F9365AB75CDEC898020100D0330C7C4BB4B36E29FC8CE2861A9C14ABC4F36A3B2A63070400C07DA70FAAED8583AD4F78C7297CC62A162BC5006BE5FE958C111000007302C1E5D6E4AF76156CB13E05521CDDA7D2BA656F86784EDC41FF0701804600AA0682A6E277D665451B4419C5534B9F58CF6F987518CF35F46F800000D43714DC265A8AB1D60E83A314584751DB3F53C53CD159FC94D3F700020060D731C57759AF92A788181617FA956AEB70112A9E10D7D32F01020010C860708BF83FD15B4CB7DE161452B0BD5668B5A1FADEFE25F188F8019FEE010200A0D336C407C50B628C582E124589E1A7175EB056E227596D32CADA82F780684EDF010800809BC3C115E287E24F56F17B4DCCB20E30DAA7F97A830A6BE5FD47D6A7F8C1D6D7267F50ABF0D5EF4E1F000800006ADFAAF81DEB12A487C4E35621555F35BC2E268985628D88B0EE45509FAA53C441912E72AC2B6ACBC53171CA3AE2F6BCF5CFC7AC7F5764FDD974EBA29B14EB6D45ACF5BDBB3A2867BE9868851575F4F2B3E231EB2DC79DD6298C4D787680B3FD3F6A5B61BFA2D238BD0000000049454E44AE426082);
INSERT INTO `tbl_basicinfo` VALUES ('35', '9172016 - 4', 'Urbina  ', 'Jasper  ', 'Sayson', '2001-09-17', '15', 'Male', '5\'5', '90', 'Aida st. Marick Sub. Cainta Rizal', 'Driver', '090 952-13367', 'Without Philhealth', 'In - Patient', '11:03:04 AM', 'September 17, 2016', 0x89504E470D0A1A0A0000000D4948445200000200000002000806000000F478D4FA0000000473424954080808087C0864880000000970485973000085B6000085B601A9B9F3CC0000001974455874536F667477617265007777772E696E6B73636170652E6F72679BEE3C1A000031F04944415478DAEDDD777CD5D5FDC7F1028AA342D5FAABB6DA3A5A6B6DFD756855ACDDED4FADD6DA5A198228842943650B88124218612343866C1551A60C995964900442980964EF89826C02FC3EA77EB511336E6EEEF7DEEFF99ED71FCFC7C347A5989CEF39E7F3BEDF7BC6372E5EBCF80D00CED5B2C3F0A6E216F133F11BF198682DBA8A0122444C150BC52A112E768A54715864886C912BF245912811E5E288382A3E13272C65D69FDF2F12ACBF6FAD5826E68B6962AC785DF4B37E8E7F8A16E2367125CF0D703E1A01086C71BF4AFC48FC513C275EB50AAC2AE449A2585C101735F3A9154022C45231D9FADD3A5801E617E21AFA00400000DC5CE4AF170F8BCE6282F848ECB63E815F349C7A1B1125DEB602C2BFC5CFC5D5F41D800000E852E86F167F15BDC50CEBD5793145DE2B17ACAF2B541BCE1603C593EAAB10FA1A4000000255E89B885F5ADF7DAB4FAE3BACEFD129DCFEA1D62F6C10A1D61B83DBE897000100B0A3E0FF403C23C659AFAB4F50841DA7426CB11627AA0592778A46F45F800000785AEC9B8B3F8BC1D642BC228AABB6D45B998FADB5050F89CBE9E3000100F8A2E05F6115FC51D696B7F3144ED73A2E368921D6A24C02010800804105BF91B8D75A54A68AC1490AA3B14E585F1BBC267EA7CE5B608C800000B8ABE8DF2EBA5807D9B0F50E35516170A3E8256E65EC800000E8B94AFF8FD6E9781914367829C53A65F101161482000038FBBBFC27AC6D7965142FD87060D11CEB2C82AB1873200000812DFACDAC2D5FEAA8D9631429F8F1AB8235D6C98E373216410000FC53F46F1041D6E534A7294608B04A6BAB617BEE36000100F07DD1BFD2FAA4BFC19A70293C70EAAE82F7C4DFD962080200D0B0C2FFA098293EA1B840336A1DCA74757D3363190400C0B3A27FB37572DB418A085C22538C147733C6410000BEFE8ABF8DF55D2A27F1C1CDE2C5F36AD70A631F0400985CF8EFB15EF17F4A6180815F11A88B8B6E672E000100A614FDC6E21F622B4500F8CF1BAF75D619168D99234000801B0BFFB7441F4EE6036A5D2B30486D7565CE0001006E28FC778969E2332678C023EA7C8B456A170C73080800D0ADE8AB1BF7FE66EDDBBFC0840E782D523CCABC0202009C5EF82FB76EDD4B63E2067C6AA7788675022000C069855F5DC4F3A2C861A2066C952A3A72D220080070C2FEFDDE229F8919F0AB5CF192B89AB9080400F8B3F05F6DADE82F62220602AA540C55BB6C989B4000809D85FF1A31509430F1028E7254BCCE8D842000C0D785BF991822CA996801472BB1BE966BCADC0502001A52F82F133DF8C40F6879A8503BB52597B90C0400D4B7F83F65AD38663205F4B55B3CCE9C0602003C29FCF75B878F307902EE3A50E821E6381000505DE1BF5DBCC7C97D80ABAD143F65CE030100AAF05F27C68B334C8E80112AC59BE25AE6400200CC3DB6B7AF38C28408187B864047160A12006056F1FFBDD8CF040840C4897B991B09007077E1BF41CCE37B7E0097382F668AEB992B090070DFF5BC1D39C807401DCAAD1B3DB9759000001714FF9F8A28263600F590201E600E250040CFC27F951825CE329901F082FAAAF02DD19C399500007D8AFFDFACA34099C400F8E2EAE147995B09007076E1FFB658CA8405C0066F73ED300100CE2CFE4F882226290036CAE76E0102009C7555EF1C2626007EB4409D22CA1C4C0040600FF4E1BB7E008150289E642E2600C0BF85FF0AEBFCFEF34C4200026C0907081100E09FE27F2FC7F8027018B5FEE8AFCCD10400D853F82F13C3D8D70FC0C1C709878A26CCD90400F8AEF8DF2AE29960006860BBF83E733701000D2FFE4FB6E4CA5E007AA9104F31871300E0FD2BFF306EEE03A0B129A229733A01009E17FF9B453493070017D8297EC4DC4E0040DDC5FF1151CAA401C0458E89B6CCF10400545FF81B8B60F6F60370B1B9EA1C13E67C0200FE5BFC6F145B991C001840ED68FA2E733F0180E2FFF971BE854C0A000C5220EEA70610004C2EFE5D38D80780A14E89F6D40202806985BF8998C4040000C3C7A93550D406028009C5BFB958CFA007802F6D10D7522308006E2EFE7770910F00542B4DDC45AD2000B875B15F39831C006AF4A9789C9A41007053F1EFC4623F00F0883A0BE5156A0701C00D87FB4C60400380578B031B514B08003A16FF6F8A750C6200F0DA3BE2726A0A0140A7E2FF6DEBB42B06300034CC66D18CDA4200D0A1F8DFC24A7F00F0A9647113358600E0E4E27F97C861B00280CF65891F536B08004E2CFEF7B5E41A5F00B093DA4ADD829A43007052F1FF73CBCFEFBB66800280BD4E88BF537B08004E28FE4F8BD30C4A00F09B4AD1811A44000864F1EF6C7544062400F8D705D1855A44000844F11FC4000480808780EED42402803F8BFF30061E0038462F6A1301C01FC57F08830D001CE7656A1401C0CEE23F904106008ED58F5A4500B0A3F8F763700180E30DA46611007C59FC5F66500180368650BB0800BE28FEBD184C70B833AD3A061F691D34A2A06DE790F4F6DD47ED0BEA357657B73E13E27B0F9ABA7DC01B6F450E1B3D2F62D4A477C227CFFA3062F6A2B5514B3EDC1CB3627DF40E45FDB3FADFD4BF537F46FD59F5FF51FF5FF577A8BF4BFD9DEAEF56FF0DF5DF52FF4DDA1D0E378C1A46006848F1EFCE2042A04F3D6BD775645ACF01936343272E097F67F9969898C47D07F71DCA2A48CF29389257527AA6A8BCE26220A8FFB6FA19D4CFA27E26F5B3C9CF18A17E56F533CBCF7E92E787001B442D23007853FCBB587B4C1944B05DEBA0E0A28E3DC7EE1A387C56E4B4B92B23D66D894FDC9B96995F585671215005BEA1D4CFAE7E87B59BE392D4EF24BF5B94FC8EC9F2BB16F3CCE1479DA9690480FA14FF0E147FD8E47450AFB0A490F18BB72DFE60D3F6ED897BF767E5177DA66B91F796FA9DB727EC3D206D1013327E5184B4C92EBE56808DC7063F4D6D23007852FCFFCEF1BEF0A5369D46E40C0A9E15BEEAE3ED3B720A4B8E9B56EC3D955D587C62D586ED89EA4D81B4591E7D07BE0CDEE2CFD43802406DC5BF45CBCF6F9A62C0A0214E767E695CC2B4B92BC393F71FCEA4B87B67D7BE43D96FCE5911256D99246D7A8A7E85065237B6DE47AD23005457FC7FDCF2F3BBA61928A8B7673B85640E0E9913BE76735C426E51C9490AB86F499B9E5AB33176E7E0117322DB740AC9A6CFC14BA5E22E6A1E01A06AF1BF4964313850BF57FB21995367AF08DF7330238722ED5FBB0FA4E74D99BD3C8A30002FE4885BA87D040055FC9B896406053C15D42B2C71F5C731F1856515E729C681DE69507E61D586ED09EAAC02FA26EA61BFF83601C0ECE27FB9D8CC608027FBF1FB0D9B199198929A4AE175A684DDA987FA0D9B11C5F903F050BCF82601C0CCE2DF48BCC320401DFBF30BC64D7B7F4B7A6E411945560FE93905E5E3A62DDDA69E1D7D187558271A1300CC0B00E3E8FCA849FBEEA376BFB7726B544169F9198AAA9E0A4ACBCEBEB7626BB43CCB14FA346A3181006056F17F854E8F1A0A7F4A547C4A3205D45DD4332508A0169D08006614FFC7C5793A3C2EF1E9CCF9ABB7159655545230DDBA60B0A2523D63F5ACE9EFB8C459F17B0280BB8BFF5D0C7E5CAA47FFC9DB5333728B28926650CF5A3D73FA3E2EA1CE81B98300E0CEE27FAD48A393E3CB7DFC4123723FDA141B4F5134937AF6AA0F301670C9F6C0E604007715FFC662039D1B96736F8C991FCEB9FC507D40F505D5271817B0AC174D0800ACF887CB3CDF7DD4DE1DC907D2287EA84AF509D5371823B04C2200B8A3F8B7A7334319396171B8BAA39E82871A16095E089DB8389CB1024B170280DEC5FF7E6E118338B368D9C6288A1C3CB1F0FD8D6A81E019C60D3B03DCBE33C0CDC5FFBB8293C00CD7AA63F091CD5149BB286CA88FCD9149C9D2773E610C19AF50DC4800D0ABF85F619DF34C0736FAB6BE1159BBF61D4EA7A0C11B3BF71ECA943E94C35832DE56B71E17ECD60030974E6BF862BF1747EF4ACFE1FC7E34CCE1ECFC72E94B7B1853C60B2600E851FCDBD259CDD673C09488BC92D2931430F8426E51C9A99E0326C730B68CA64E8F7D8400E0ECE2FF23718CCE6AAEE163177C2C93F6790A177CBD43E0F5CFCF0B609C99AB54DC4C007066F16F2A76D249CDD5F7B5199B2956B0539FA1D33942D86CD1E2320280F302C0143AA7B9827A85EDE0EA5ED82DBFA4EC5CC75E63931973460B230038ABF83F45A73457DBCE216959F945472850F0878CBCC2A3CF760EC964EC19EB82789200E08CE2FF7D5141A734769F7FC9DEB4CC2C0A13FC29E56046BEF4BD72C6A0B18E885B0900812DFE4D04DFC999EB44F48E3DBB29480884F0D8E4039C346AB478DDD703E81E0042E984E66ECBF9604D4434850881B474D5B604EB953063D24CC308008129FE7FB5F666D2090D14F6E65256FCC311C64C79379A3169F47D01F71200FC5BFCAF1745743E33B5EF362AA5B0ACBC92E2032728282D3F2F7D3295B169ACFDEAF8790280FF02C0123A9DB937FB25EC3E7880C2032789DBB93F5DFAE639C6A7B1C61300FC53FC9FA4B3996BC4F845BCFA872305872DE4AB00B38F0AFE3D01C0DEE27F9D753D231DCE40CF760A49E78C7F38F8CE8033D247B93DD05CEA6C88660400FB02C0023A99B9876F6C89DE9944A181936D0C4FD8CB5835DA1C02803DC5FF713A97B9FA0F9BB98D02031DF47D6D462C63D6684F10007C5BFCBF25F2E958C69EF65794C951BFD0447A6EC131E9B3658C5D63A91D6ADF2600F82E00BC4DA732D7D4D9CBB75058A093496F7DC009A5665B4A00F04DF17F94CE64F4A7FF8A9CC2E2631415E8242BBFE8A4F4DDA38C61A33D46006858F16F2E72E948E61A396131DBFEA0A511E316B12DD06C19E22A0280F701E02D3A91D997FD1CCEC92FA1984047A999B9EAC6B8D38C63A38D24007857FC1FE0920DB30D0A9EB59542029D0D7CE3AD18C6B2D927978A9F1000EA57FC1B8B043A8FD1CEED4DCDCCA4884067C9FB0FE7736999F1B61100EA1700BAD069CCD66BE094480A08DCA0E780C93B18D3C66B4F00F0FCA6BF723A8CD936472525523CE0061F8727EC614C1BAF441D654F00A83B00CCA4B318BFF5AF98EB7EE1A6EB82A54FF3A1066F11006A2FFEF7F27D19060E9F154EE180CB1603723010D4A2F6160480EA8B7F23114727C1E6A8A49D140DB8EA92A088C414C636C46ED18400F0F5001044E740AB8EC125BCFE874BBF06E07E00283D08005F2DFED78A523A06060E9F1541C1802BBF06183E2B8A310EABD6352700FC3700BC49A7C07F5EFF472625532CE0469B22137733C661194500F8BCF8FF5454D221A08EFE2D282D3B47B1803BBF06283BA7FA38E31CE294F83E01A0C3F0957406281D7A8EE1D33F5CAD438F312C06C41716191D00A4011EA213E00BC1610BB75124E066C3C72E8864ACA3CAB6C07B4D0E000C067C69D586ED711409B8D98A7551498C7538E59E804016FFC779F8A89A86D3730A4A291270B3B4ACDC4F18EBB8C4DF8D0A00D6A13FAC88C597DA741A9141818009A4AFE731E651C50171994901A01D0F1D55F51E3495DBFF60845E03A7703B202EF5A21101407ED1A62293078EAA464D7A6733C501261839617134631ED5DC16D8CC8400D09B878D4B2D5AB68913006184F9EF6D8867CCA31A435C1D00E417BCC64A3A3C6C7C45786C321700C1089BA392F633E6510D7565F4356E0E00AFF390519DB4CCDC7C8A034CB0EF505639631E3518E8CA0020BFD8B7C4511E30AAF1994C8CE7290E30416159B9EAF36718F7A8612DC0D56E0C004378B8A8610B603A8501866D05CC67ECA3067D5C150054A2E1BA5FD4A46D979107280A3089F4797642A12645E24A3705809778A8A849FBEEA37653146092F6DD46A532F6518BDEAE0800F28B5C2E7279A0A8F116C01E6392280A30C90B3DC6EC63ECA316EA2BA22BDC10003AF230519B4EBDC3E2290A304950EF308E4247C04F07B4BBF83716BCEA42ADBAF5991043518049BABE326127631F75C8516FD0750E00CFF01051979E03A644511460921E03262730F6E1812E3A0700522EEAF4CA9069E1140598E4E5C16FC631F6E101F506BD917601407EE8477978F0C48037DEDA46518049FA0F9B19CBD887871ED3310044F2E0E089BEAFCDE00D008CD267E8F418C63E3CB44EAB00203FF0833C3478AA7BDF89B114059844FA3C6B00E0A90BE24E9D02C0221E1A3C3E07A0E798648A024CD2A1C79814C63EEA618A1601407ED01BC4691E183CD5AE6BE8418A024C227D9EEDD1A80F75915E331D02C0201E16EA170046A651146056001899C6D847A08F07B6E3E01F2EB90001002000C0B7D27CBD25D0D701E0091E120800000100CEDF12E8EB00B08E070402004000802DD63B3200C80F76BB38CF030201002000C0B62D813F76620018CBC30101002000C056931C1500E407BA4294F1604000000800B05599AF6E09F45500789E870202004000805F3CEDA40010CF030101002000C02FD6382200C80F72370F030400800000BF39276E74420018C9C30001002000C0AFFA39210070F21F0800000100FEB52FA001407E80DFF010400000080008885F0732004CE70180000010001010D3031200D43E44F6FE8300001000103047D4393C8108007FA7F1410000080008A856810800EFD1F02000000400E8794190B7C5FF1A718286070100200020A02AC50DFE0C00ED697410000002001C21C89F01E0631A1C04008000004758EB9700A08E1FB45E39D0E8200000040004DE69D1CC1F01A0338D0D0200400080A3B4F647005843438300001000E0284B6D0D00F21FB84A9CA4A14100000800709463F53D14A8BE01E0491A190400800000477AC2CE003087060601002000C091DEB62500C85FDC4814D1C020000004003892BA9FA7891D01E0011A17040080000047FBA31D012084860501002000C0D1A6DA110052685810000002001C2DC3A70140FEC25B69541000000200B470BB2F03402F1A1404008000002D74F16500D848838200001000A085653E0900F21735E5F43F1000000200B451AEB6EEFB2200FC8EC60401002000402BF7FA2200BC46438200001000A09581BE08005B68481000000200B4B2A9410140FE82CBC5091A120400800000ADA8B57B573424003C4C238200001000A0A53F3724000CA1014100000800D0D2A88604804D342008000001005A4AF02A0058DFFF1FA7014100000800D0D279D1CC9B00F0108D0702004000803BD701D416005EA5E14000000800D0DAABDE04808F69381000000200B4B6A25E01409D212C8ED2702000000400682DBFBE01E04E1A0D040080000057F85E7D02406B1A0C040080000057F8677D02C0581A0CFE0B00A107290A302B00841E64ECC38F46D72700700110FCE5CCFAAD3B92280A3089EAF3AAEF33FEE1275BEB13002A6830F8E3908A77576CDD4E41808954DFB70E6A612E80DDD4A2FE46750600F943B7D158F087E96FAFDA462180C9D418602E809FDCED4900F8370D05BB05872DDC4201002AFE33169813E0072F781200426928D8A96D97916905A5E5E798FC818A8B6A2CC89838C4DC009B4DF724006CA0A160A30B5BA277B2E80FA8627354523273036C16E9490028A1A16097DE83A64630E1035FD76BE09418E608D8A8B4D600207FE0161A0976AE444DCDCC2D60B207BEEE607A4E714BAE6087BDBE5D5B00789206825D42C62FDAC4440FD4BA20308AB90236FA6D6D0160200D04BBECDC7BE800933C50B31DC90732992B60A32EB50580D934106C5AF9CF71BF8007DA760EC962CE804D26D61600C26920D861CC94773733B903751B35E99D68E60CD864436D01209F06821D92F71FE6C63FC0038929A939CC19B04976B50140FEC5D56A8F360D045F6BD3694406133BE039193305CC1DB0E31C16F1CDEA02C0CF691CD821A8575802933AE0B98EBDC6A63077C026F7551700B80300B6E833743A87FF00F5F0CA90691C0A04BB3C575D00789586811D464E58CCAD7F403D848C5F14C9DC019B84561700DEA6616087398BD74632A9039E9BBDE8237602C02E1F54170038810AB658B331963500403DACD91893C8DC019BC45717008A6818D8615364E26E2675C0736ACC3077C026F95F0900F23F5C43A38000001000E07A95A249D500F00B1A05040080000023DC5235003C46838000001000608416550340071A040400800000233C53350070060008000001006678A56A00984C8380000010006084F15503C0521A040400800000232CAD1A0022681010000002008CB0BD6A0048A5414000000800304276D500F0290D02020040008011CE8AC6AAF85F4963800000100060941B5400B88D860001002000C0283F5201A0050D01020040008051EE5301E09F3404080000010046F9B30A005D690810000002008CF2B40A00FD680810000002008CD2510580D7690810000002008CD2470580B1340408000001004619AE02C0341A020400800000A34C5201603E0D01020040008051E6AB00B08C860001002000C0282B5400584B43800000100060946D2A0084D31020000004001865A70A00093404080000010046495501603F0D010200400080510EA900904D4380000010006094741500CA680810000002008C92A902C0091A020400800000A36411004000000800304F8E0A0047690810000002008C92A702C0111A020400800000A314B008100400800000F314A900504C43800000100060946215000A6808D869E5FAE81D4CEA80E73EDA149BC4DC019B95AA00904343C04E6FCE5D19C1A40E786EE1FB1B63983B60B3721500326908D86948C8DC702675C07313677E10C5DC019B1D5101E0300D013B757D65421C933AE0B961A3E7453377C066152A00A4D210B053DB2E235399D401CFF5E83F3991B90336CBE53640F8C33199D42E30B103752B2CABB8D8AA637039F3066C76500580141A02763B989193CBE40ED42D61772A37B4C21F125500D84543C06E13672CDBC2E40ED46DC6BCD57CFF0F7F08570180EF9A60BB369D46641696559C6782076AD7F9E5719C01007F58AB02402C0D017F58BF75473C133C50B35DFB0EAB73592E305FC00F96AA00B08186803F74EF3B3186491EA8D9ABC1B3D9FF0F7F99AB02C0BB3404FCE4DCC18C9C02267AE0EB32F20A8FC91839C13C013F99A202C0341A02FE121CB6602B933DC0E13F08B8501500426808F8F32DC0B698E414267CE0BFB627EE3D2463A392F9017E34580580BE3404FCA975D088FC8CDC82234CFC40C5C582D2B2CA765D430F3137C0CF5E5201A0030D017FEBD677223B02003172C2625EFD2310825400788A864020CC98B78A6B8261B4F9EF7DCC366C044A2B15007E474320404E47C4EDDE4B218089D66E8EDBA9D6C4300F20401E5701E01E1A02017472E9CA6DB1140498645364E26EE9FBC719FF08A0FB5500B8998640805D089DB824BCB08C1B03E17E33E7AF8EE1933F1CE0161500AEA221E0043DFA4F8ECD2D2A394991801BE5979456F67F7D661C631D4EF8D0252EFBC6C58B175508384D83C0099EEB167A202BBFE8330A06DC64C3B61D7BDB761999C518874394A8DAFF450028A441E014EFAF0E674D005C61DFA1ACA21EFD27EF605CC36176570D00FB69103845DFA1D3A3281ED0D9E6A89D7B7B0F9A1ACBDB5538D486AA0120820681734E0A0C2EA2884047AB366CDFF96CE7906CC6311CEEEDAA0160010D0227D9B1FB601A0505BA69D7752447FA420723AB068037681038C9C4991F845350A093F8E403E98C5D68A267D500F03C0D0227E9D873EC4E8A0A74F2FAE8F9918C5D68E25F5503C0EF691038CC99ECC262B603420B8565E5E75B070517336EA189165503C0F7691038CDCAF5D171141768B2CF3F99310B8DDC5A3500341667691438C9C037DEE2B64068E1E5C1D3B63366A191A65F06002B04B080058ED22668440EC5054E97535872B22517FB401FE55FD4FDAA0160330D03A7D9B5EF703A45064EB6E4C3CD318C556824B1BA0030878681D3BC3977C5368A0C9CACF34BE39218ABD0C8E2EA02C0101A064E2393EB0E8A0C9C2A2D33B754FA692563151A195A5D00684BC3C0814E65E41556506CE04453E7AC60EF3F74F3EFEA02C043340C9C68E682D57C0D00477AAE5BE841C62834F3B3EA02C04D340C9C4826D9BD141B384DD29EB40CC6273453F9C516C04B034023719206821325A6A4A65274E0248343E6708B2A7473E88B9AFF950060850056B3C2915E0B7D7B2B45074E919157F8297BFFA1A135B50580B934109CA855C7E0D282D2B233141F38C184E9CB58FC071D85D516007AD14070AA15EBA263293E08B4FC92B2735CFC034D05D516007E4B03C1A9BAF599400040C02D5AB63196F1084DFDA6B600D05C5CA091E050670F65E59550841048EDBA86A63116A1A9EB6A0C005608606B0B1C6BCAACE52C0644C07C1C9EB08771084D955C5AEFAB0B00CB69283855DB2E23D90E8880E9F2F2F89D8C43682AD29300308C8682936D4FD8BB8762047F4B4C49CD66FC4163533C09004FD25070B27EC366465090E06FFD86CD60F11F74D6D69300F07D1A0A0E772A2D33B798A2047F49CDCCFD44FADD69C61E34F6C33A038015022A682C38D9F0B10BB820087E133A71490CE30E1A2BABAED6D71400B6D16070B8A359F94547294EB05B4E61C999561D838F30E6A0B175F5090013693038DDF8E9EFF31600B69B3A7B39DFFD4377AFD727003C4F83C1E9E45359495E71E9298A146CBBF427B7E084F4B34F196FD0DCA3F509003FA6C1A083D98B3E8AA450C12EC1610BF9EE1FBABB70E90980B506002B0414D17070BA369D46641796955752ACE06BFB0F6797AB1D278C33682EADA63A5F5B00789F86830EDE5BB9358682059FEFFB7F6D461CE30B2EB0C89B00D09386830EDA750D3D48C1822F25EC3E98237DEB3CE30B2ED0D39B00700F0D075DACDB129F44E182AF74ED338133FFE116BFF626003412E5341E74F0C28BA353285CF085CD514907185370CBA9A9E2F27A07002B04ACA401A18B15EBA2E3296068A8E75F1C4D00805BC4D456E3EB0A00AFD080D0C5B39D43320A4ACBCF51C4E0AD656B2292184B7091110D0900F7D280D0C9AC859C0B00EFE49794554A88CC611CC1457ED79000D058700A16B43A1D30BBA0F838050DF5F5D682351CF90B3739262EF33A005821601D0D099D844E5CC21D01A897ACFCA293121ECB183F7091D575D5774F02C0401A129A399E9A915B446183A75E0D9ECD91BF3066FF7F7D02C083342474D36FD80CD602C0235BA377EEB7CE4B67ECC04DEEF44500B84C7DA2A231A199CAA43D69872970A84D6E71E999673B8764335EE0325975D5768F0280150256D3A0D04D9797C7EFA0C8A18EDBFEA2192B70A1D9BE0C0041342874F4FEEAF0ED143A542736695FBA7A53C438810B3DE3CB00F09D965C8C013DB7059666E4165450F05055416959E5735D430F3146E042AA565FE7B30060850056C9424B2F0F7E338AA287AAC64D5BCAAB7FB855BCA775BD3E0180ED80D0D6DACD71AC07C07FECDC7B489DF6779A7101138FFFF53600DC45C34257AD8346E46517167F4601345B6159F9C5177A8CD9C79880A9C7FF7A1500AC109046E34257AF06CFE68440C3CD98BF9AAF32E166E5751DFFDB900010460343E7C531E131C9C9144233ED4BCB2CE64C13B8DC9CFAD4F4FA0680876960E8ECD9CE21E97925A5A72888E6E9FCF2B85D8C01B8DC23760600753B60298D0C9D8D18B7680B05D12C13677EB09DBE0F5EFF3720005821601E0D0DCD9D8DDBB57F3F85D10C1B2312F772E00F0C30B7BEF5DC9B00F0140D0DDD3DD735747F4169F9390AA4BB1D389C5DD6AA6370397D1E0678D41F01E06A7192C686EE26CC58C657012E965F525AF9FC8BA30FD0D761808AFABEFEF72A00582160150D0E1738B9FB407A3AC5D29D5E1D313B963E0E43BCED4D2DF736003C4383C3155F05740BDDC7AE00F759F2E1E644FA370CF2983F03C015E2088D0E3718F0C65BE1144DF7884F3E90C5D7943088AAC597FB2D00582160260D0FB7904F8C5C1BEC02197985279EED1C924B9F8641E6795BC71B12005AD0F07091E38929A91914519DCFF9AFB8D8BDEF440EFB81691EF77B00E06E00B8F094C0CCFC9232B6066A6AEAECE52CFA83693EF1F6F5BF2F02C0501E00DC2423AFF028C5544FBD074DDD411F86616637A486373400FC405CE0218000000200E077F7072C005821601B0F010400100000BF4A6968FDF645007881070102000800805FF5764200B8A625776C8300000200E02FA7C475010F00560858C4030101000400C02F96F8A276FB2A00FC95070202000800805FFCD14901A0B1E0F42D1000400000EC75C81775DB67018033014000000100F08B414E0C00FF632D4CE0018100000200E07BE7C48D8E0B00560898C7030201000400C0162B7C59B37D1D007EC9030201000400C0168F3B360058212092870402000800804FA985F68D9D1E009EE6418100000200E053037D5DAFED08004D44360F0B04001000009F382ABEE5F800608580013C3010004000007C629C1DB5DAAE00709D38C1430301000400A041CE8A5BB40900560898C9830301000400A04116DA55A7ED0C0077F3E0400000010068907BB40B005608D8C4C30301000400C02BEBEDACD1760780277880200080000078E54F3A078046229987080200080040BD24DA599F6D0F005608F8270F1204001000807A69E58600C05B0010004000003C97A10ED5D33E00F0160004001000807AE9E98FDAECAF00C05B001000400000EA562CAE764D00E02D0008002000001EE9EDAFBAECCF00C05B0010004000006A96239ABA2E00F0160004001000805A05F9B326FB3B00F016000400100080AF4BF3C7CAFF800500DE02800000020050AD36FEAEC7810800BC058063E515979EA6986A1B00E2E9C3D0548AAA8DAE0F00BC0580839DA490EAABFFEB3363E8C3D0D49381A8C5810A00EA2D40020F1D4ED23A28B89842AAAFE0B085D1F46368282E1075386001C00A010FF3E0E1246DBB8C3C4C21D5D7A4991F1000A0A3BF181700AC10F03E0F1F4ED1A977581285545F6FBFB33E967E0CCD6C0D640D0E7400B8559CA213C00982C316865348F5B57EEB8E14FA3134D3C2D800608580503A019CE0C38F22E329A4FACAC82D382ECFF1027D199A5819E8FAEB8400708D28A23320D0F61FCE2EA490EAEDD9CE21D9F4656840BDF9BEDDF800608580203A0402A94DD0883C0AA8FE5E1E3C2D8EFE0C0D0C7742ED754A00682C76D12910286F8C5D104101D5DFDC25EB080070BA2C711501E0AB21E00F740C044ADCAEFD691450FDA5E7161C95E779863E0D07FB9753EAAE630280150296D339E0F7FDFF9D43D2299EEED1BDDF44EE0480536D7452CD755A00B8439CA693C09FA6CC5ECEEB7F1759BE36923B01E04467C55D0480DA43C0583A0AFCA555C7E092DCA212EE007091FC92B233F25C8BE9DF709830A7D55B270680E66C0B84BFBC3977651445D37D66CE5F1D41FF868314A82DEF0400CF42C0D37418D8AD755070917CFAE7FA5F77BE0538DBA6D3883CFA391CA29D136BAD23038015023EA4D3C0E693FF122996EEB5F0FD8D6C0984134439B5CE3A3900DC248ED079608757864C8BA548BA5B4169F985E75F1CBD9FFE8E00AA14BF20007817023AD081E0FB57FF230A33F30A3FA348BADF9ED48CC2561D871FA3DF83857F9A05002B046CA213C1874E6F89DEB98FE2688E77966F49A0DF23000E8A2B09000D0B00B789E37426F8C0F9656B22765014CDD3F7B519B1F47FF873AE6919E0AB7E5D1100AC10F0121D0A0D3573C11AB6FC99BB2BE05C9797C7EF641C8057FFFA0500755910091EDEBA307EFAFB9CF66738B5E5B343CF317B180F30FDD5BF5601C00A017773C907BC7072E9CA6DACF8C77F64E5179D68DF7DD441C6054C7EF5AF5D00B042C0303A18EA73CC6F547C0A0BFEF015398525A77A0D9CC27D0130F6D5BFAE01E072914227435DBAF59D187F3023A79882879A4C9EF561B4B54F9B3103A35EFD6B1900AC10F02BBE0A408D7BFC3B06172F5B131147818327364624A67064304C7BF5AF6D00B042401F3A1C2E71F6D5E0D9911979859F52D850AFC581C5A567C64E7D2F4AFAD009C6114C78F5AF7B006824D6D3E9A0F4E83F3976F781C3D9143334C4FE435945BD064E51F7075C605CC1CDAFFEB50E005608F84E4BAE0D36DA0B3DC6A444B2C80F3EB623F9607A8FFE93E20902F0E4CDA3B85FD73AAA6D00B042C0230C52F33CDB392463C5FAE8048A15080208B03E3AD750AD03801502C2E884E62CF09BB3786D5441697925050A040104D86ADDEBA71B0280DA1A98486774B5CFC64C79373CA7B0E4040509040138408EB89E00E08C10F023C1959F2EFC7E6D50F0ECC843D979E514201004E010E7C4436EA89DAE08005608684FC774D3CAFE4971ACEC0741000E34C02D75D33501C00A018BE99CACEC070802B0C93AB50D9D00E0CC00D04CA4D34959D90F1004E063EAC4C81BDC54335D1500AC10F06B719ACEAAC9CAFEA0E092398BD746B3B21F04013898BA33E2B76EAB97AE0B005608E84087D562657F042BFB4110800686B8B156BA3200582160129DD6B92BFBD3B258D90F7382C08B04019D6D74D3F7FEA6048026620B9DD7592BFB93F7B3B21F0401E6036D64BAED7B7F2302801502AE171974E2C0AFEC8F88DBCDCA7E8020A01375B6CCCFDC5C235D1D00AC10708FFABE99CECCCA7E8020000F9D174FB8BD3EBA3E005821E05F0C3256F603040178A8BF09B5D1880060858037E8D4FE59D99F5D58CCCA7E8020A0ABF9A6D44593024023B182CE6DCFD9D8ACEC0708022EB05D342500B833045C23F6D2C97DE7C57E93E259D90F10045C205BFC8F4935D1A8006085803B44059DBDC12BFBF7B0B21F2008B8E5EB4BF1BFA6D543E302801502FE24CED0E9BD5AD99FB9625D142BFB0182809B56FCFFC3C45A686400B042402BEBC133003C59D9DF9195FD806382403F82800F0D32B50E1A1B00AC10D093CE5FA7E3ACEC0708022E35CFE41A687400B042400883A08695FDC36745B1B21F707C10384C10F0CA2A75643C0180103087C1C0CA7E8020608C7071A5E9B58F00F0DF8B8356B1B27FCC9EC8B8DDFB994C0182808BED14CDA97D0480AA21E04A11CDCA7E000401D74A336DAF3F01C0F31070AD490705A995FDB317B1B21F200818214FFC805A4700A82D04DC2C725CBFB27FF2BB91ACEC0708028628177753E308009E8480BBAC0EC3CA7E000401FD4FF9BB9FDA4600A84F0878D0EA38AE59D9BF6B1F2BFB01181504D489AF7FA1A61100BC09010F8B637AAFEC1FADCEEC67653F80DA82409C0B8340A5F837B58C00D09010F01B1D43805AD9BF9C95FD00CC0C02EA98F70ED43002802F42C043E2A85E2BFBCB58D90FC0C420A03EF93F47ED2200F83204B470780860653F00D383C039D19A9A4500B06B61E0A74EEBF003D5CAFECC5C56F603B021081C38A44910382B9EA6561100EC0C010F382504B0B21F0041E0CBD5FE4F52A30800FE0801F78B4F58D90F80201070A7C4DFA84D04007F86805F8B23ACEC0740100858F13F29FE8F9A4400084408B8CF1F218095FD0008025F5FF82CFE482D2200043204FC4A94D8D5C1474F7E8795FD0008025FA5CE66F92D358800E08410F04371C8971DBC47FFC9710733724A995800E81604BAF599B0C3C6E2AFD65FB5A0F610009C14026E10F10D7EDD1F34A260F5C731894C240074B67EEB8E5D6D3B8764F8B8F8AB9B5A7F4ACD21003831045C2DD6787B7AD5D0917323B20B8B8F3379007083FC92B27353662F8F6AD5D127C7A9278BEF516B08004E0E014DC45BF5E9D8EDBA861ED89EB8976D7D005C292D33B7A2CFD0E9B10D581FB05134A3C61000740902433DE9D8C346CF8B28282D3FC72401C0ED22E353D29EEB165ADFF552F3C465D41502806E21E079EB78CAEA3AF58977576C8D65520060D6D702A5E7068F9813EB61F11F4E2D2100E81C021EB9F43AE1369D46E4C5EF3A7098C90080A996AEDC9668EDE5AFE9529F206A0801C02D670514AA8EDDA97758727A6EC1A74C00004CB76BDFA1DC765D461EAE668FFFA3D40E02809B42C0AD23272C5E5B505A7E9E810F009FCB292C39652D10BC687D50FA15358300E03AD2D96F159CE50F009798B364DD2A29FE3FA0561000DC1C02AE103319F000F0A5B5E23A6A0401C09420D05E70C63F0093A90BCE068B46D40502806921E07FC521260100062A167FA21610004C0E01CDC572260300068914DFA5061000F07910E82F381110809B5D10630527FB1100704908F8BD28629200E0429F88A798EB0900A83904DC64BD1E63C200E016BBC41DCCF10400D41D022E13E3983400B8C06C7125733B0100F50B024F8BA34C200034A4B6393FCF5C4E0080F721E04EB187C9048046D2C43DCCE10400343C045C2D1631A900D0C032D18CB99B0000DF0681EEE234130C00073A2B5E62AE2600C0BE10F04B6B452D130E00A7C8112D98A30900F0CF2E8141E214130F800052D79B4FE3953F010081592018C124042000F68987988B0900085C086824BA8A4F999000F8815A87344C34650E2600C01941E066B19AC909808DA2C44F9873090070661068254A98A800F8907AC3D84DBD71649E2500C0D921E07AB180490B800FA8EBCAB9BA970000CD82C023228B090C8017F2C53F994B0900D037047C534CB6B6EB30A901A8CB05314334670E2500C01D41E0416BDB0E131C809A1C100F33671200E0BE10D054BC21CE30D101A842CD09C3D9DA470080FB83C0CF441C931E00B15DDCCDDC4800803921A0B1784E64320102462AB12E18636B1F0100860681CB454F51CC840818E11331542D10660E2400005FEC1618CA91C2806B9D10A3C575CC792000A0A64384C2C449264CC0350BFCDE143731C78100004FEF169825CE3181025AAAB44E04BD8D390D0400787BE5F052EB70102655400F1FB2B21F0400F82A08FC4A6C6062051C6DA3B88F390B0400D81104FE20629968014789516393390A0400F82308FC43EC65E205026AB778823909040004E230A1F6DC3808F8DD21D186437C40008013EE18E8C6654380ED3244677119730F0800705A18F89358616D4162C2067C733DEF7AF1B87AEBC63C0302009C1E04BE2F4689322670C0EB237B27881F32A78000001D83C015E20591C8840E78BCB0AF8BB89A39040400B8250CB4104BACA34999E881FF3A6B1DB8F55BE60A1000E0E62070A318260A98F861B842F186F82E730308003029085C265A89280A010CA3FA7C6B751D3773010800303D0CFC42CCB1AE2CA540C0ADD7F1CE163F67CC8300007C3D085C27FA59FB9D291A7083C3A28FB896310E020050771068642D1A1C471880868AC44CF1174EEB030100685820F8A5081107282E70A82C6BDFFEC31CD8030200604F18F889182A76517410602A908E54D7653336410000FC1B066EB7D60CC45A47A6529460B72431440551C62008008033C2C0F7444FB18DBB08E043E745B4B590EF56C61A080080B3C3C00DA29375890A270FC29B93F9365AB75CDEC898020100D0330C7C4BB4B36E29FC8CE2861A9C14ABC4F36A3B2A63070400C07DA70FAAED8583AD4F78C7297CC62A162BC5006BE5FE958C111000007302C1E5D6E4AF76156CB13E05521CDDA7D2BA656F86784EDC41FF0701804600AA0682A6E277D665451B4419C5534B9F58CF6F987518CF35F46F800000D43714DC265A8AB1D60E83A314584751DB3F53C53CD159FC94D3F700020060D731C57759AF92A788181617FA956AEB70112A9E10D7D32F01020010C860708BF83FD15B4CB7DE161452B0BD5668B5A1FADEFE25F188F8019FEE010200A0D336C407C50B628C582E124589E1A7175EB056E227596D32CADA82F780684EDF010800809BC3C115E287E24F56F17B4DCCB20E30DAA7F97A830A6BE5FD47D6A7F8C1D6D7267F50ABF0D5EF4E1F000800006ADFAAF81DEB12A487C4E35621555F35BC2E268985628D88B0EE45509FAA53C441912E72AC2B6ACBC53171CA3AE2F6BCF5CFC7AC7F5764FDD974EBA29B14EB6D45ACF5BDBB3A2867BE9868851575F4F2B3E231EB2DC79DD6298C4D787680B3FD3F6A5B61BFA2D238BD0000000049454E44AE426082);
INSERT INTO `tbl_basicinfo` VALUES ('36', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '1994-10-02', '21', 'Male', '5\'7', '120', 'Riverside Cainta,Rizal', 'Designer', '091 655-53055', 'With Philhealth', 'Out - Patient', '02:14:30 PM', 'September 17, 2016', 0x89504E470D0A1A0A0000000D4948445200000200000002000806000000F478D4FA0000000473424954080808087C0864880000000970485973000085B6000085B601A9B9F3CC0000001974455874536F667477617265007777772E696E6B73636170652E6F72679BEE3C1A000031F04944415478DAEDDD777CD5D5FDC7F1028AA342D5FAABB6DA3A5A6B6DFD756855ACDDED4FADD6DA5A198228842943650B88124218612343866C1551A60C995964900442980964EF89826C02FC3EA77EB511336E6EEEF7DEEFF99ED71FCFC7C347A5989CEF39E7F3BEDF7BC6372E5EBCF80D00CED5B2C3F0A6E216F133F11BF198682DBA8A0122444C150BC52A112E768A54715864886C912BF245912811E5E288382A3E13272C65D69FDF2F12ACBF6FAD5826E68B6962AC785DF4B37E8E7F8A16E2367125CF0D703E1A01086C71BF4AFC48FC513C275EB50AAC2AE449A2585C101735F3A9154022C45231D9FADD3A5801E617E21AFA00400000DC5CE4AF170F8BCE6282F848ECB63E815F349C7A1B1125DEB602C2BFC5CFC5D5F41D800000E852E86F167F15BDC50CEBD5793145DE2B17ACAF2B541BCE1603C593EAAB10FA1A4000000255E89B885F5ADF7DAB4FAE3BACEFD129DCFEA1D62F6C10A1D61B83DBE897000100B0A3E0FF403C23C659AFAB4F50841DA7426CB11627AA0592778A46F45F800000785AEC9B8B3F8BC1D642BC228AABB6D45B998FADB5050F89CBE9E3000100F8A2E05F6115FC51D696B7F3144ED73A2E368921D6A24C02010800804105BF91B8D75A54A68AC1490AA3B14E585F1BBC267EA7CE5B608C800000B8ABE8DF2EBA5807D9B0F50E35516170A3E8256E65EC800000E8B94AFF8FD6E9781914367829C53A65F101161482000038FBBBFC27AC6D7965142FD87060D11CEB2C82AB1873200000812DFACDAC2D5FEAA8D9631429F8F1AB8235D6C98E373216410000FC53F46F1041D6E534A7294608B04A6BAB617BEE36000100F07DD1BFD2FAA4BFC19A70293C70EAAE82F7C4DFD962080200D0B0C2FFA098293EA1B840336A1DCA74757D3363190400C0B3A27FB37572DB418A085C22538C147733C6410000BEFE8ABF8DF55D2A27F1C1CDE2C5F36AD70A631F0400985CF8EFB15EF17F4A6180815F11A88B8B6E672E000100A614FDC6E21F622B4500F8CF1BAF75D619168D99234000801B0BFFB7441F4EE6036A5D2B30486D7565CE0001006E28FC778969E2332678C023EA7C8B456A170C73080800D0ADE8AB1BF7FE66EDDBBFC0840E782D523CCABC0202009C5EF82FB76EDD4B63E2067C6AA7788675022000C069855F5DC4F3A2C861A2066C952A3A72D220080070C2FEFDDE229F8919F0AB5CF192B89AB9080400F8B3F05F6DADE82F62220602AA540C55BB6C989B4000809D85FF1A31509430F1028E7254BCCE8D842000C0D785BF991822CA996801472BB1BE966BCADC0502001A52F82F133DF8C40F6879A8503BB52597B90C0400D4B7F83F65AD38663205F4B55B3CCE9C0602003C29FCF75B878F307902EE3A50E821E6381000505DE1BF5DBCC7C97D80ABAD143F65CE030100AAF05F27C68B334C8E80112AC59BE25AE6400200CC3DB6B7AF38C28408187B864047160A12006056F1FFBDD8CF040840C4897B991B09007077E1BF41CCE37B7E0097382F668AEB992B090070DFF5BC1D39C807401DCAAD1B3DB9759000001714FF9F8A28263600F590201E600E250040CFC27F951825CE329901F082FAAAF02DD19C399500007D8AFFDFACA34099C400F8E2EAE147995B09007076E1FFB658CA8405C0066F73ED300100CE2CFE4F882226290036CAE76E0102009C7555EF1C2626007EB4409D22CA1C4C0040600FF4E1BB7E008150289E642E2600C0BF85FF0AEBFCFEF34C4200026C0907081100E09FE27F2FC7F8027018B5FEE8AFCCD10400D853F82F13C3D8D70FC0C1C709878A26CCD90400F8AEF8DF2AE29960006860BBF83E733701000D2FFE4FB6E4CA5E007AA9104F31871300E0FD2BFF306EEE03A0B129A229733A01009E17FF9B453493070017D8297EC4DC4E0040DDC5FF1151CAA401C0458E89B6CCF10400545FF81B8B60F6F60370B1B9EA1C13E67C0200FE5BFC6F145B991C001840ED68FA2E733F0180E2FFF971BE854C0A000C5220EEA70610004C2EFE5D38D80780A14E89F6D40202806985BF8998C4040000C3C7A93550D406028009C5BFB958CFA007802F6D10D7522308006E2EFE7770910F00542B4DDC45AD2000B875B15F39831C006AF4A9789C9A41007053F1EFC4623F00F0883A0BE5156A0701C00D87FB4C60400380578B031B514B08003A16FF6F8A750C6200F0DA3BE2726A0A0140A7E2FF6DEBB42B06300034CC66D18CDA4200D0A1F8DFC24A7F00F0A9647113358600E0E4E27F97C861B00280CF65891F536B08004E2CFEF7B5E41A5F00B093DA4ADD829A43007052F1FF73CBCFEFBB66800280BD4E88BF537B08004E28FE4F8BD30C4A00F09B4AD1811A44000864F1EF6C7544062400F8D705D1855A44000844F11FC4000480808780EED42402803F8BFF30061E0038462F6A1301C01FC57F08830D001CE7656A1401C0CEE23F904106008ED58F5A4500B0A3F8F763700180E30DA46611007C59FC5F66500180368650BB0800BE28FEBD184C70B833AD3A061F691D34A2A06DE790F4F6DD47ED0BEA357657B73E13E27B0F9ABA7DC01B6F450E1B3D2F62D4A477C227CFFA3062F6A2B5514B3EDC1CB3627DF40E45FDB3FADFD4BF537F46FD59F5FF51FF5FF577A8BF4BFD9DEAEF56FF0DF5DF52FF4DDA1D0E378C1A46006848F1EFCE2042A04F3D6BD775645ACF01936343272E097F67F9969898C47D07F71DCA2A48CF29389257527AA6A8BCE26220A8FFB6FA19D4CFA27E26F5B3C9CF18A17E56F533CBCF7E92E787001B442D23007853FCBB587B4C1944B05DEBA0E0A28E3DC7EE1A387C56E4B4B92B23D66D894FDC9B96995F585671215005BEA1D4CFAE7E87B59BE392D4EF24BF5B94FC8EC9F2BB16F3CCE1479DA9690480FA14FF0E147FD8E47450AFB0A490F18BB72DFE60D3F6ED897BF767E5177DA66B91F796FA9DB727EC3D206D1013327E5184B4C92EBE56808DC7063F4D6D23007852FCFFCEF1BEF0A5369D46E40C0A9E15BEEAE3ED3B720A4B8E9B56EC3D955D587C62D586ED89EA4D81B4591E7D07BE0CDEE2CFD43802406DC5BF45CBCF6F9A62C0A0214E767E695CC2B4B92BC393F71FCEA4B87B67D7BE43D96FCE5911256D99246D7A8A7E85065237B6DE47AD23005457FC7FDCF2F3BBA61928A8B7673B85640E0E9913BE76735C426E51C9490AB86F499B9E5AB33176E7E0117322DB740AC9A6CFC14BA5E22E6A1E01A06AF1BF4964313850BF57FB21995367AF08DF7330238722ED5FBB0FA4E74D99BD3C8A30002FE4885BA87D040055FC9B896406053C15D42B2C71F5C731F1856515E729C681DE69507E61D586ED09EAAC02FA26EA61BFF83601C0ECE27FB9D8CC608027FBF1FB0D9B199198929A4AE175A684DDA987FA0D9B11C5F903F050BCF82601C0CCE2DF48BCC320401DFBF30BC64D7B7F4B7A6E411945560FE93905E5E3A62DDDA69E1D7D187558271A1300CC0B00E3E8FCA849FBEEA376BFB7726B544169F9198AAA9E0A4ACBCEBEB7626BB43CCB14FA346A3181006056F17F854E8F1A0A7F4A547C4A3205D45DD4332508A0169D08006614FFC7C5793A3C2EF1E9CCF9ABB7159655545230DDBA60B0A2523D63F5ACE9EFB8C459F17B0280BB8BFF5D0C7E5CAA47FFC9DB5333728B28926650CF5A3D73FA3E2EA1CE81B98300E0CEE27FAD48A393E3CB7DFC4123723FDA141B4F5134937AF6AA0F301670C9F6C0E604007715FFC662039D1B96736F8C991FCEB9FC507D40F505D5271817B0AC174D0800ACF887CB3CDF7DD4DE1DC907D2287EA84AF509D5371823B04C2200B8A3F8B7A7334319396171B8BAA39E82871A16095E089DB8389CB1024B170280DEC5FF7E6E118338B368D9C6288A1C3CB1F0FD8D6A81E019C60D3B03DCBE33C0CDC5FFBB8293C00CD7AA63F091CD5149BB286CA88FCD9149C9D2773E610C19AF50DC4800D0ABF85F619DF34C0736FAB6BE1159BBF61D4EA7A0C11B3BF71ECA943E94C35832DE56B71E17ECD60030974E6BF862BF1747EF4ACFE1FC7E34CCE1ECFC72E94B7B1853C60B2600E851FCDBD259CDD673C09488BC92D2931430F8426E51C9A99E0326C730B68CA64E8F7D8400E0ECE2FF23718CCE6AAEE163177C2C93F6790A177CBD43E0F5CFCF0B609C99AB54DC4C007066F16F2A76D249CDD5F7B5199B2956B0539FA1D33942D86CD1E2320280F302C0143AA7B9827A85EDE0EA5ED82DBFA4EC5CC75E63931973460B230038ABF83F45A73457DBCE216959F945472850F0878CBCC2A3CF760EC964EC19EB82789200E08CE2FF7D5141A734769F7FC9DEB4CC2C0A13FC29E56046BEF4BD72C6A0B18E885B0900812DFE4D04DFC999EB44F48E3DBB29480884F0D8E4039C346AB478DDD703E81E0042E984E66ECBF9604D4434850881B474D5B604EB953063D24CC308008129FE7FB5F666D2090D14F6E65256FCC311C64C79379A3169F47D01F71200FC5BFCAF1745743E33B5EF362AA5B0ACBC92E2032728282D3F2F7D3295B169ACFDEAF8790280FF02C0123A9DB937FB25EC3E7880C2032789DBB93F5DFAE639C6A7B1C61300FC53FC9FA4B3996BC4F845BCFA872305872DE4AB00B38F0AFE3D01C0DEE27F9D753D231DCE40CF760A49E78C7F38F8CE8033D247B93DD05CEA6C88660400FB02C0023A99B9876F6C89DE9944A181936D0C4FD8CB5835DA1C02803DC5FF713A97B9FA0F9BB98D02031DF47D6D462C63D6684F10007C5BFCBF25F2E958C69EF65794C951BFD0447A6EC131E9B3658C5D63A91D6ADF2600F82E00BC4DA732D7D4D9CBB75058A093496F7DC009A5665B4A00F04DF17F94CE64F4A7FF8A9CC2E2631415E8242BBFE8A4F4DDA38C61A33D46006858F16F2E72E948E61A396131DBFEA0A511E316B12DD06C19E22A0280F701E02D3A91D997FD1CCEC92FA1984047A999B9EAC6B8D38C63A38D24007857FC1FE0920DB30D0A9EB59542029D0D7CE3AD18C6B2D927978A9F1000EA57FC1B8B043A8FD1CEED4DCDCCA4884067C9FB0FE7736999F1B61100EA1700BAD069CCD66BE094480A08DCA0E780C93B18D3C66B4F00F0FCA6BF723A8CD936472525523CE0061F8727EC614C1BAF441D654F00A83B00CCA4B318BFF5AF98EB7EE1A6EB82A54FF3A1066F11006A2FFEF7F27D19060E9F154EE180CB1603723010D4A2F6160480EA8B7F23114727C1E6A8A49D140DB8EA92A088C414C636C46ED18400F0F5001044E740AB8EC125BCFE874BBF06E07E00283D08005F2DFED78A523A06060E9F1541C1802BBF06183E2B8A310EABD6352700FC3700BC49A7C07F5EFF472625532CE0469B22137733C661194500F8BCF8FF5454D221A08EFE2D282D3B47B1803BBF06283BA7FA38E31CE294F83E01A0C3F0957406281D7A8EE1D33F5CAD438F312C06C41716191D00A4011EA213E00BC1610BB75124E066C3C72E8864ACA3CAB6C07B4D0E000C067C69D586ED711409B8D98A7551498C7538E59E804016FFC779F8A89A86D3730A4A291270B3B4ACDC4F18EBB8C4DF8D0A00D6A13FAC88C597DA741A9141818009A4AFE731E651C50171994901A01D0F1D55F51E3495DBFF60845E03A7703B202EF5A21101407ED1A62293078EAA464D7A6733C501261839617134631ED5DC16D8CC8400D09B878D4B2D5AB68913006184F9EF6D8867CCA31A435C1D00E417BCC64A3A3C6C7C45786C321700C1089BA392F633E6510D7565F4356E0E00AFF390519DB4CCDC7C8A034CB0EF505639631E3518E8CA0020BFD8B7C4511E30AAF1994C8CE7290E30416159B9EAF36718F7A8612DC0D56E0C004378B8A8610B603A8501866D05CC67ECA3067D5C150054A2E1BA5FD4A46D979107280A3089F4797642A12645E24A3705809778A8A849FBEEA37653146092F6DD46A532F6518BDEAE0800F28B5C2E7279A0A8F116C01E6392280A30C90B3DC6EC63ECA316EA2BA22BDC10003AF230519B4EBDC3E2290A304950EF308E4247C04F07B4BBF83716BCEA42ADBAF5991043518049BABE326127631F75C8516FD0750E00CFF01051979E03A644511460921E03262730F6E1812E3A0700522EEAF4CA9069E1140598E4E5C16FC631F6E101F506BD917601407EE8477978F0C48037DEDA46518049FA0F9B19CBD887871ED3310044F2E0E089BEAFCDE00D008CD267E8F418C63E3CB44EAB00203FF0833C3478AA7BDF89B114059844FA3C6B00E0A90BE24E9D02C0221E1A3C3E07A0E798648A024CD2A1C79814C63EEA618A1601407ED01BC4691E183CD5AE6BE8418A024C227D9EEDD1A80F75915E331D02C0201E16EA170046A651146056001899C6D847A08F07B6E3E01F2EB90001002000C0B7D27CBD25D0D701E0091E120800000100CEDF12E8EB00B08E070402004000802DD63B3200C80F76BB38CF030201002000C0B62D813F76620018CBC30101002000C056931C1500E407BA4294F1604000000800B05599AF6E09F45500789E870202004000805F3CEDA40010CF030101002000C02FD6382200C80F72370F030400800000BF39276E74420018C9C30001002000C0AFFA39210070F21F0800000100FEB52FA001407E80DFF010400000080008885F0732004CE70180000010001010D3031200D43E44F6FE8300001000103047D4393C8108007FA7F1410000080008A856810800EFD1F02000000400E8794190B7C5FF1A718286070100200020A02AC50DFE0C00ED697410000002001C21C89F01E0631A1C04008000004758EB9700A08E1FB45E39D0E8200000040004DE69D1CC1F01A0338D0D0200400080A3B4F647005843438300001000E0284B6D0D00F21FB84A9CA4A14100000800709463F53D14A8BE01E0491A190400800000477AC2CE003087060601002000C091DEB62500C85FDC4814D1C020000004003892BA9FA7891D01E0011A17040080000047FBA31D012084860501002000C0D1A6DA110052685810000002001C2DC3A70140FEC25B69541000000200B470BB2F03402F1A1404008000002D74F16500D848838200001000A085653E0900F21735E5F43F1000000200B451AEB6EEFB2200FC8EC60401002000402BF7FA2200BC46438200001000A09581BE08005B68481000000200B4B2A9410140FE82CBC5091A120400800000ADA8B57B573424003C4C238200001000A0A53F3724000CA1014100000800D0D2A88604804D342008000001005A4AF02A0058DFFF1FA7014100000800D0D279D1CC9B00F0108D0702004000803BD701D416005EA5E14000000800D0DAABDE04808F69381000000200B4B6A25E01409D212C8ED2702000000400682DBFBE01E04E1A0D040080000057F85E7D02406B1A0C040080000057F8677D02C0581A0CFE0B00A107290A302B00841E64ECC38F46D72700700110FCE5CCFAAD3B92280A3089EAF3AAEF33FEE1275BEB13002A6830F8E3908A77576CDD4E41808954DFB70E6A612E80DDD4A2FE46750600F943B7D158F087E96FAFDA462180C9D418602E809FDCED4900F8370D05BB05872DDC4201002AFE33169813E0072F781200426928D8A96D97916905A5E5E798FC818A8B6A2CC89838C4DC009B4DF724006CA0A160A30B5BA277B2E80FA8627354523273036C16E9490028A1A16097DE83A64630E1035FD76BE09418E608D8A8B4D600207FE0161A0976AE444DCDCC2D60B207BEEE607A4E714BAE6087BDBE5D5B00789206825D42C62FDAC4440FD4BA20308AB90236FA6D6D0160200D04BBECDC7BE800933C50B31DC90732992B60A32EB50580D934106C5AF9CF71BF8007DA760EC962CE804D26D61600C26920D861CC94773733B903751B35E99D68E60CD864436D01209F06821D92F71FE6C63FC0038929A939CC19B04976B50140FEC5D56A8F360D045F6BD3694406133BE039193305CC1DB0E31C16F1CDEA02C0CF691CD821A8575802933AE0B98EBDC6A63077C026F7551700B80300B6E833743A87FF00F5F0CA90691C0A04BB3C575D00789586811D464E58CCAD7F403D848C5F14C9DC019B84561700DEA6616087398BD74632A9039E9BBDE8237602C02E1F54170038810AB658B331963500403DACD91893C8DC019BC45717008A6818D8615364E26E2675C0736ACC3077C026F95F0900F23F5C43A38000001000E07A95A249D500F00B1A05040080000023DC5235003C46838000001000608416550340071A040400800000233C53350070060008000001006678A56A00984C8380000010006084F15503C0521A040400800000232CAD1A0022681010000002008CB0BD6A0048A5414000000800304276D500F0290D02020040008011CE8AC6AAF85F4963800000100060941B5400B88D860001002000C0283F5201A0050D01020040008051EE5301E09F3404080000010046F9B30A005D690810000002008CF2B40A00FD680810000002008CD2510580D7690810000002008CD2470580B1340408000001004619AE02C0341A020400800000A34C5201603E0D01020040008051E6AB00B08C860001002000C0282B5400584B43800000100060946D2A0084D31020000004001865A70A00093404080000010046495501603F0D010200400080510EA900904D4380000010006094741500CA680810000002008C92A902C0091A020400800000A36411004000000800304F8E0A0047690810000002008C92A702C0111A020400800000A314B008100400800000F314A900504C43800000100060946215000A6808D869E5FAE81D4CEA80E73EDA149BC4DC019B95AA00904343C04E6FCE5D19C1A40E786EE1FB1B63983B60B3721500326908D86948C8DC702675C07313677E10C5DC019B1D5101E0300D013B757D65421C933AE0B961A3E7453377C066152A00A4D210B053DB2E235399D401CFF5E83F3991B90336CBE53640F8C33199D42E30B103752B2CABB8D8AA637039F3066C76500580141A02763B989193CBE40ED42D61772A37B4C21F125500D84543C06E13672CDBC2E40ED46DC6BCD57CFF0F7F08570180EF9A60BB369D46641696559C6782076AD7F9E5719C01007F58AB02402C0D017F58BF75473C133C50B35DFB0EAB73592E305FC00F96AA00B08186803F74EF3B3186491EA8D9ABC1B3D9FF0F7F99AB02C0BB3404FCE4DCC18C9C02267AE0EB32F20A8FC91839C13C013F99A202C0341A02FE121CB6602B933DC0E13F08B8501500426808F8F32DC0B698E414267CE0BFB627EE3D2463A392F9017E34580580BE3404FCA975D088FC8CDC82234CFC40C5C582D2B2CA765D430F3137C0CF5E5201A0030D017FEBD677223B02003172C2625EFD2310825400788A864020CC98B78A6B8261B4F9EF7DCC366C044A2B15007E474320404E47C4EDDE4B218089D66E8EDBA9D6C4300F20401E5701E01E1A02017472E9CA6DB1140498645364E26EE9FBC719FF08A0FB5500B8998640805D089DB824BCB08C1B03E17E33E7AF8EE1933F1CE0161500AEA221E0043DFA4F8ECD2D2A394991801BE5979456F67F7D661C631D4EF8D0252EFBC6C58B175508384D83C0099EEB167A202BBFE8330A06DC64C3B61D7BDB761999C518874394A8DAFF450028A441E014EFAF0E674D005C61DFA1ACA21EFD27EF605CC36176570D00FB69103845DFA1D3A3281ED0D9E6A89D7B7B0F9A1ACBDB5538D486AA0120820681734E0A0C2EA2884047AB366CDFF96CE7906CC6311CEEEDAA0160010D0227D9B1FB601A0505BA69D7752447FA420723AB068037681038C9C4991F845350A093F8E403E98C5D68A267D500F03C0D0227E9D873EC4E8A0A74F2FAE8F9918C5D68E25F5503C0EF691038CC99ECC262B603420B8565E5E75B070517336EA189165503C0F7691038CDCAF5D171141768B2CF3F99310B8DDC5A3500341667691438C9C037DEE2B64068E1E5C1D3B63366A191A65F06002B04B080058ED22668440EC5054E97535872B22517FB401FE55FD4FDAA0160330D03A7D9B5EF703A45064EB6E4C3CD318C556824B1BA0030878681D3BC3977C5368A0C9CACF34BE39218ABD0C8E2EA02C0101A064E2393EB0E8A0C9C2A2D33B754FA692563151A195A5D00684BC3C0814E65E41556506CE04453E7AC60EF3F74F3EFEA02C043340C9C68E682D57C0D00477AAE5BE841C62834F3B3EA02C04D340C9C4826D9BD141B384DD29EB40CC6273453F9C516C04B034023719206821325A6A4A65274E0248343E6708B2A7473E88B9AFF950060850056B3C2915E0B7D7B2B45074E919157F8297BFFA1A135B50580B934109CA855C7E0D282D2B233141F38C184E9CB58FC071D85D516007AD14070AA15EBA263293E08B4FC92B2735CFC034D05D516007E4B03C1A9BAF599400040C02D5AB63196F1084DFDA6B600D05C5CA091E050670F65E59550841048EDBA86A63116A1A9EB6A0C005608606B0B1C6BCAACE52C0644C07C1C9EB08771084D955C5AEFAB0B00CB69283855DB2E23D90E8880E9F2F2F89D8C43682AD29300308C8682936D4FD8BB8762047F4B4C49CD66FC4163533C09004FD25070B27EC366465090E06FFD86CD60F11F74D6D69300F07D1A0A0E772A2D33B798A2047F49CDCCFD44FADD69C61E34F6C33A038015022A682C38D9F0B10BB820087E133A71490CE30E1A2BABAED6D71400B6D16070B8A359F94547294EB05B4E61C999561D838F30E6A0B175F5090013693038DDF8E9EFF31600B69B3A7B39DFFD4377AFD727003C4F83C1E9E45359495E71E9298A146CBBF427B7E084F4B34F196FD0DCA3F509003FA6C1A083D98B3E8AA450C12EC1610BF9EE1FBABB70E90980B506002B0414D17070BA369D46641796955752ACE06BFB0F6797AB1D278C33682EADA63A5F5B00789F86830EDE5BB9358682059FEFFB7F6D461CE30B2EB0C89B00D09386830EDA750D3D48C1822F25EC3E98237DEB3CE30B2ED0D39B00700F0D075DACDB129F44E182AF74ED338133FFE116BFF626003412E5341E74F0C28BA353285CF085CD514907185370CBA9A9E2F27A07002B04ACA401A18B15EBA2E3296068A8E75F1C4D00805BC4D456E3EB0A00AFD080D0C5B39D43320A4ACBCF51C4E0AD656B2292184B7091110D0900F7D280D0C9AC859C0B00EFE49794554A88CC611CC1457ED79000D058700A16B43A1D30BBA0F838050DF5F5D682351CF90B3739262EF33A005821601D0D099D844E5CC21D01A897ACFCA293121ECB183F7091D575D5774F02C0401A129A399E9A915B446183A75E0D9ECD91BF3066FF7F7D02C083342474D36FD80CD602C0235BA377EEB7CE4B67ECC04DEEF44500B84C7DA2A231A199CAA43D69872970A84D6E71E999673B8764335EE0325975D5768F0280150256D3A0D04D9797C7EFA0C8A18EDBFEA2192B70A1D9BE0C0041342874F4FEEAF0ED143A542736695FBA7A53C438810B3DE3CB00F09D965C8C013DB7059666E4165450F05055416959E5735D430F3146E042AA565FE7B30060850056C9424B2F0F7E338AA287AAC64D5BCAAB7FB855BCA775BD3E0180ED80D0D6DACD71AC07C07FECDC7B489DF6779A7101138FFFF53600DC45C34257AD8346E46517167F4601345B6159F9C5177A8CD9C79880A9C7FF7A1500AC109046E34257AF06CFE68440C3CD98BF9AAF32E166E5751DFFDB900010460343E7C531E131C9C9144233ED4BCB2CE64C13B8DC9CFAD4F4FA0680876960E8ECD9CE21E97925A5A72888E6E9FCF2B85D8C01B8DC23760600753B60298D0C9D8D18B7680B05D12C13677EB09DBE0F5EFF3720005821601E0D0DCD9D8DDBB57F3F85D10C1B2312F772E00F0C30B7BEF5DC9B00F0140D0DDD3DD735747F4169F9390AA4BB1D389C5DD6AA6370397D1E0678D41F01E06A7192C686EE26CC58C657012E965F525AF9FC8BA30FD0D761808AFABEFEF72A00582160150D0E1738B9FB407A3AC5D29D5E1D313B963E0E43BCED4D2DF736003C4383C3155F05740BDDC7AE00F759F2E1E644FA370CF2983F03C015E2088D0E3718F0C65BE1144DF7884F3E90C5D7943088AAC597FB2D00582160260D0FB7904F8C5C1BEC02197985279EED1C924B9F8641E6795BC71B12005AD0F07091E38929A91914519DCFF9AFB8D8BDEF440EFB81691EF77B00E06E00B8F094C0CCFC9232B6066A6AEAECE52CFA83693EF1F6F5BF2F02C0501E00DC2423AFF028C5544FBD074DDD411F86616637A486373400FC405CE0218000000200E077F7072C005821601B0F010400100000BF4A6968FDF645007881070102000800805FF5764200B8A625776C8300000200E02FA7C475010F00560858C4030101000400C02F96F8A276FB2A00FC95070202000800805FFCD14901A0B1E0F42D1000400000EC75C81775DB67018033014000000100F08B414E0C00FF632D4CE0018100000200E07BE7C48D8E0B00560898C7030201000400C0162B7C59B37D1D007EC9030201000400C0168F3B360058212092870402000800804FA985F68D9D1E009EE6418100000200E053037D5DAFED08004D44360F0B04001000009F382ABEE5F800608580013C3010004000007C629C1DB5DAAE00709D38C1430301000400A041CE8A5BB40900560898C9830301000400A04116DA55A7ED0C0077F3E0400000010068907BB40B005608D8C4C30301000400C02BEBEDACD1760780277880200080000078E54F3A078046229987080200080040BD24DA599F6D0F005608F8270F1204001000807A69E58600C05B0010004000003C97A10ED5D33E00F0160004001000807AE9E98FDAECAF00C05B001000400000EA562CAE764D00E02D0008002000001EE9EDAFBAECCF00C05B0010004000006A96239ABA2E00F0160004001000805A05F9B326FB3B00F016000400100080AF4BF3C7CAFF800500DE02800000020050AD36FEAEC7810800BC058063E515979EA6986A1B00E2E9C3D0548AAA8DAE0F00BC0580839DA490EAABFFEB3363E8C3D0D49381A8C5810A00EA2D40020F1D4ED23A28B89842AAAFE0B085D1F46368282E1075386001C00A010FF3E0E1246DBB8C3C4C21D5D7A4991F1000A0A3BF181700AC10F03E0F1F4ED1A977581285545F6FBFB33E967E0CCD6C0D640D0E7400B8559CA213C00982C316865348F5B57EEB8E14FA3134D3C2D800608580503A019CE0C38F22E329A4FACAC82D382ECFF1027D199A5819E8FAEB8400708D28A23320D0F61FCE2EA490EAEDD9CE21D9F4656840BDF9BEDDF800608580203A0402A94DD0883C0AA8FE5E1E3C2D8EFE0C0D0C7742ED754A00682C76D12910286F8C5D104101D5DFDC25EB080070BA2C711501E0AB21E00F740C044ADCAEFD691450FDA5E7161C95E779863E0D07FB9753EAAE630280150296D339E0F7FDFF9D43D2299EEED1BDDF44EE0480536D7452CD755A00B8439CA693C09FA6CC5ECEEB7F1759BE36923B01E04467C55D0480DA43C0583A0AFCA555C7E092DCA212EE007091FC92B233F25C8BE9DF709830A7D55B270680E66C0B84BFBC3977651445D37D66CE5F1D41FF868314A82DEF0400CF42C0D37418D8AD755070917CFAE7FA5F77BE0538DBA6D3883CFA391CA29D136BAD23038015023EA4D3C0E693FF122996EEB5F0FD8D6C0984134439B5CE3A3900DC248ED079608757864C8BA548BA5B4169F985E75F1CBD9FFE8E00AA14BF20007817023AD081E0FB57FF230A33F30A3FA348BADF9ED48CC2561D871FA3DF83857F9A05002B046CA213C1874E6F89DEB98FE2688E77966F49A0DF23000E8A2B09000D0B00B789E37426F8C0F9656B22765014CDD3F7B519B1F47FF873AE6919E0AB7E5D1100AC10F0121D0A0D3573C11AB6FC99BB2BE05C9797C7EF641C8057FFFA0500755910091EDEBA307EFAFB9CF66738B5E5B343CF317B180F30FDD5BF5601C00A017773C907BC7072E9CA6DACF8C77F64E5179D68DF7DD441C6054C7EF5AF5D00B042C0303A18EA73CC6F547C0A0BFEF015398525A77A0D9CC27D0130F6D5BFAE01E072914227435DBAF59D187F3023A79882879A4C9EF561B4B54F9B3103A35EFD6B1900AC10F02BBE0A408D7BFC3B06172F5B131147818327364624A67064304C7BF5AF6D00B042401F3A1C2E71F6D5E0D9911979859F52D850AFC581C5A567C64E7D2F4AFAD009C6114C78F5AF7B006824D6D3E9A0F4E83F3976F781C3D9143334C4FE435945BD064E51F7075C605CC1CDAFFEB50E005608F84E4BAE0D36DA0B3DC6A444B2C80F3EB623F9607A8FFE93E20902F0E4CDA3B85FD73AAA6D00B042C0230C52F33CDB392463C5FAE8048A15080208B03E3AD750AD03801502C2E884E62CF09BB3786D5441697925050A040104D86ADDEBA71B0280DA1A98486774B5CFC64C79373CA7B0E4040509040138408EB89E00E08C10F023C1959F2EFC7E6D50F0ECC843D979E514201004E010E7C4436EA89DAE08005608684FC774D3CAFE4971ACEC0741000E34C02D75D33501C00A018BE99CACEC070802B0C93AB50D9D00E0CC00D04CA4D34959D90F1004E063EAC4C81BDC54335D1500AC10F06B719ACEAAC9CAFEA0E092398BD746B3B21F04013898BA33E2B76EAB97AE0B005608E84087D562657F042BFB4110800686B8B156BA3200582160129DD6B92BFBD3B258D90F7382C08B04019D6D74D3F7FEA6048026620B9DD7592BFB93F7B3B21F0401E6036D64BAED7B7F2302801502AE171974E2C0AFEC8F88DBCDCA7E8020A01375B6CCCFDC5C235D1D00AC10708FFABE99CECCCA7E8020000F9D174FB8BD3EBA3E005821E05F0C3256F603040178A8BF09B5D1880060858037E8D4FE59D99F5D58CCCA7E8020A0ABF9A6D44593024023B182CE6DCFD9D8ACEC0708022EB05D342500B833045C23F6D2C97DE7C57E93E259D90F10045C205BFC8F4935D1A8006085803B44059DBDC12BFBF7B0B21F2008B8E5EB4BF1BFA6D543E302801502FE24CED0E9BD5AD99FB9625D142BFB0182809B56FCFFC3C45A686400B042402BEBC133003C59D9DF9195FD806382403F82800F0D32B50E1A1B00AC10D093CE5FA7E3ACEC0708022E35CFE41A687400B042400883A08695FDC36745B1B21F707C10384C10F0CA2A75643C0180103087C1C0CA7E8020608C7071A5E9B58F00F0DF8B8356B1B27FCC9EC8B8DDFB994C0182808BED14CDA97D0480AA21E04A11CDCA7E000401D74A336DAF3F01C0F31070AD490705A995FDB317B1B21F200818214FFC805A4700A82D04DC2C725CBFB27FF2BB91ACEC0708028628177753E308009E8480BBAC0EC3CA7E000401FD4FF9BB9FDA4600A84F0878D0EA38AE59D9BF6B1F2BFB01181504D489AF7FA1A61100BC09010F8B637AAFEC1FADCEEC67653F80DA82409C0B8340A5F837B58C00D09010F01B1D43805AD9BF9C95FD00CC0C02EA98F70ED43002802F42C043E2A85E2BFBCB58D90FC0C420A03EF93F47ED2200F83204B470780860653F00D383C039D19A9A4500B06B61E0A74EEBF003D5CAFECC5C56F603B021081C38A44910382B9EA6561100EC0C010F382504B0B21F0041E0CBD5FE4F52A30800FE0801F78B4F58D90F80201070A7C4DFA84D04007F86805F8B23ACEC0740100858F13F29FE8F9A4400084408B8CF1F218095FD0008025F5FF82CFE482D2200043204FC4A94D8D5C1474F7E8795FD0008025FA5CE66F92D358800E08410F04371C8971DBC47FFC9710733724A995800E81604BAF599B0C3C6E2AFD65FB5A0F610009C14026E10F10D7EDD1F34A260F5C731894C240074B67EEB8E5D6D3B8764F8B8F8AB9B5A7F4ACD21003831045C2DD6787B7AD5D0917323B20B8B8F3379007083FC92B27353662F8F6AD5D127C7A9278BEF516B08004E0E014DC45BF5E9D8EDBA861ED89EB8976D7D005C292D33B7A2CFD0E9B10D581FB05134A3C61000740902433DE9D8C346CF8B28282D3FC72401C0ED22E353D29EEB165ADFF552F3C465D41502806E21E079EB78CAEA3AF58977576C8D65520060D6D702A5E7068F9813EB61F11F4E2D2100E81C021EB9F43AE1369D46E4C5EF3A7098C90080A996AEDC9668EDE5AFE9529F206A0801C02D670514AA8EDDA97758727A6EC1A74C00004CB76BDFA1DC765D461EAE668FFFA3D40E02809B42C0AD23272C5E5B505A7E9E810F009FCB292C39652D10BC687D50FA15358300E03AD2D96F159CE50F009798B364DD2A29FE3FA0561000DC1C02AE103319F000F0A5B5E23A6A0401C09420D05E70C63F0093A90BCE068B46D40502806921E07FC521260100062A167FA21610004C0E01CDC572260300068914DFA5061000F07910E82F381110809B5D10630527FB1100704908F8BD28629200E0429F88A798EB0900A83904DC64BD1E63C200E016BBC41DCCF10400D41D022E13E3983400B8C06C7125733B0100F50B024F8BA34C200034A4B6393FCF5C4E0080F721E04EB187C9048046D2C43DCCE10400343C045C2D1631A900D0C032D18CB99B0000DF0681EEE234130C00073A2B5E62AE2600C0BE10F04B6B452D130E00A7C8112D98A30900F0CF2E8141E214130F800052D79B4FE3953F010081592018C124042000F68987988B0900085C086824BA8A4F999000F8815A87344C34650E2600C01941E066B19AC909808DA2C44F9873090070661068254A98A800F8907AC3D84DBD71649E2500C0D921E07AB180490B800FA8EBCAB9BA970000CD82C023228B090C8017F2C53F994B0900D037047C534CB6B6EB30A901A8CB05314334670E2500C01D41E0416BDB0E131C809A1C100F33671200E0BE10D054BC21CE30D101A842CD09C3D9DA470080FB83C0CF441C931E00B15DDCCDDC4800803921A0B1784E64320102462AB12E18636B1F0100860681CB454F51CC840818E11331542D10660E2400005FEC1618CA91C2806B9D10A3C575CC792000A0A64384C2C449264CC0350BFCDE143731C78100004FEF169825CE3181025AAAB44E04BD8D390D0400787BE5F052EB70102655400F1FB2B21F0400F82A08FC4A6C6062051C6DA3B88F390B0400D81104FE20629968014789516393390A0400F82308FC43EC65E205026AB778823909040004E230A1F6DC3808F8DD21D186437C40008013EE18E8C6654380ED3244677119730F0800705A18F89358616D4162C2067C733DEF7AF1B87AEBC63C0302009C1E04BE2F4689322670C0EB237B27881F32A78000001D83C015E20591C8840E78BCB0AF8BB89A39040400B8250CB4104BACA34999E881FF3A6B1DB8F55BE60A1000E0E62070A318260A98F861B842F186F82E730308003029085C265A89280A010CA3FA7C6B751D3773010800303D0CFC42CCB1AE2CA540C0ADD7F1CE163F67CC8300007C3D085C27FA59FB9D291A7083C3A28FB896310E020050771068642D1A1C471880868AC44CF1174EEB030100685820F8A5081107282E70A82C6BDFFEC31CD8030200604F18F889182A76517410602A908E54D7653336410000FC1B066EB7D60CC45A47A6529460B72431440551C62008008033C2C0F7444FB18DBB08E043E745B4B590EF56C61A080080B3C3C00DA29375890A270FC29B93F9365AB75CDEC898020100D0330C7C4BB4B36E29FC8CE2861A9C14ABC4F36A3B2A63070400C07DA70FAAED8583AD4F78C7297CC62A162BC5006BE5FE958C111000007302C1E5D6E4AF76156CB13E05521CDDA7D2BA656F86784EDC41FF0701804600AA0682A6E277D665451B4419C5534B9F58CF6F987518CF35F46F800000D43714DC265A8AB1D60E83A314584751DB3F53C53CD159FC94D3F700020060D731C57759AF92A788181617FA956AEB70112A9E10D7D32F01020010C860708BF83FD15B4CB7DE161452B0BD5668B5A1FADEFE25F188F8019FEE010200A0D336C407C50B628C582E124589E1A7175EB056E227596D32CADA82F780684EDF010800809BC3C115E287E24F56F17B4DCCB20E30DAA7F97A830A6BE5FD47D6A7F8C1D6D7267F50ABF0D5EF4E1F000800006ADFAAF81DEB12A487C4E35621555F35BC2E268985628D88B0EE45509FAA53C441912E72AC2B6ACBC53171CA3AE2F6BCF5CFC7AC7F5764FDD974EBA29B14EB6D45ACF5BDBB3A2867BE9868851575F4F2B3E231EB2DC79DD6298C4D787680B3FD3F6A5B61BFA2D238BD0000000049454E44AE426082);
INSERT INTO `tbl_basicinfo` VALUES ('37', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '1960-09-20', '56', 'Male', '5\'8', '120', 'Cainta, Rizal', 'Professor', '099 581-56433', 'With Philhealth', 'In - Patient', '07:41:17 PM', 'September 20, 2016', 0x89504E470D0A1A0A0000000D4948445200000200000002000806000000F478D4FA0000000473424954080808087C0864880000000970485973000085B6000085B601A9B9F3CC0000001974455874536F667477617265007777772E696E6B73636170652E6F72679BEE3C1A000031F04944415478DAEDDD777CD5D5FDC7F1028AA342D5FAABB6DA3A5A6B6DFD756855ACDDED4FADD6DA5A198228842943650B88124218612343866C1551A60C995964900442980964EF89826C02FC3EA77EB511336E6EEEF7DEEFF99ED71FCFC7C347A5989CEF39E7F3BEDF7BC6372E5EBCF80D00CED5B2C3F0A6E216F133F11BF198682DBA8A0122444C150BC52A112E768A54715864886C912BF245912811E5E288382A3E13272C65D69FDF2F12ACBF6FAD5826E68B6962AC785DF4B37E8E7F8A16E2367125CF0D703E1A01086C71BF4AFC48FC513C275EB50AAC2AE449A2585C101735F3A9154022C45231D9FADD3A5801E617E21AFA00400000DC5CE4AF170F8BCE6282F848ECB63E815F349C7A1B1125DEB602C2BFC5CFC5D5F41D800000E852E86F167F15BDC50CEBD5793145DE2B17ACAF2B541BCE1603C593EAAB10FA1A4000000255E89B885F5ADF7DAB4FAE3BACEFD129DCFEA1D62F6C10A1D61B83DBE897000100B0A3E0FF403C23C659AFAB4F50841DA7426CB11627AA0592778A46F45F800000785AEC9B8B3F8BC1D642BC228AABB6D45B998FADB5050F89CBE9E3000100F8A2E05F6115FC51D696B7F3144ED73A2E368921D6A24C02010800804105BF91B8D75A54A68AC1490AA3B14E585F1BBC267EA7CE5B608C800000B8ABE8DF2EBA5807D9B0F50E35516170A3E8256E65EC800000E8B94AFF8FD6E9781914367829C53A65F101161482000038FBBBFC27AC6D7965142FD87060D11CEB2C82AB1873200000812DFACDAC2D5FEAA8D9631429F8F1AB8235D6C98E373216410000FC53F46F1041D6E534A7294608B04A6BAB617BEE36000100F07DD1BFD2FAA4BFC19A70293C70EAAE82F7C4DFD962080200D0B0C2FFA098293EA1B840336A1DCA74757D3363190400C0B3A27FB37572DB418A085C22538C147733C6410000BEFE8ABF8DF55D2A27F1C1CDE2C5F36AD70A631F0400985CF8EFB15EF17F4A6180815F11A88B8B6E672E000100A614FDC6E21F622B4500F8CF1BAF75D619168D99234000801B0BFFB7441F4EE6036A5D2B30486D7565CE0001006E28FC778969E2332678C023EA7C8B456A170C73080800D0ADE8AB1BF7FE66EDDBBFC0840E782D523CCABC0202009C5EF82FB76EDD4B63E2067C6AA7788675022000C069855F5DC4F3A2C861A2066C952A3A72D220080070C2FEFDDE229F8919F0AB5CF192B89AB9080400F8B3F05F6DADE82F62220602AA540C55BB6C989B4000809D85FF1A31509430F1028E7254BCCE8D842000C0D785BF991822CA996801472BB1BE966BCADC0502001A52F82F133DF8C40F6879A8503BB52597B90C0400D4B7F83F65AD38663205F4B55B3CCE9C0602003C29FCF75B878F307902EE3A50E821E6381000505DE1BF5DBCC7C97D80ABAD143F65CE030100AAF05F27C68B334C8E80112AC59BE25AE6400200CC3DB6B7AF38C28408187B864047160A12006056F1FFBDD8CF040840C4897B991B09007077E1BF41CCE37B7E0097382F668AEB992B090070DFF5BC1D39C807401DCAAD1B3DB9759000001714FF9F8A28263600F590201E600E250040CFC27F951825CE329901F082FAAAF02DD19C399500007D8AFFDFACA34099C400F8E2EAE147995B09007076E1FFB658CA8405C0066F73ED300100CE2CFE4F882226290036CAE76E0102009C7555EF1C2626007EB4409D22CA1C4C0040600FF4E1BB7E008150289E642E2600C0BF85FF0AEBFCFEF34C4200026C0907081100E09FE27F2FC7F8027018B5FEE8AFCCD10400D853F82F13C3D8D70FC0C1C709878A26CCD90400F8AEF8DF2AE29960006860BBF83E733701000D2FFE4FB6E4CA5E007AA9104F31871300E0FD2BFF306EEE03A0B129A229733A01009E17FF9B453493070017D8297EC4DC4E0040DDC5FF1151CAA401C0458E89B6CCF10400545FF81B8B60F6F60370B1B9EA1C13E67C0200FE5BFC6F145B991C001840ED68FA2E733F0180E2FFF971BE854C0A000C5220EEA70610004C2EFE5D38D80780A14E89F6D40202806985BF8998C4040000C3C7A93550D406028009C5BFB958CFA007802F6D10D7522308006E2EFE7770910F00542B4DDC45AD2000B875B15F39831C006AF4A9789C9A41007053F1EFC4623F00F0883A0BE5156A0701C00D87FB4C60400380578B031B514B08003A16FF6F8A750C6200F0DA3BE2726A0A0140A7E2FF6DEBB42B06300034CC66D18CDA4200D0A1F8DFC24A7F00F0A9647113358600E0E4E27F97C861B00280CF65891F536B08004E2CFEF7B5E41A5F00B093DA4ADD829A43007052F1FF73CBCFEFBB66800280BD4E88BF537B08004E28FE4F8BD30C4A00F09B4AD1811A44000864F1EF6C7544062400F8D705D1855A44000844F11FC4000480808780EED42402803F8BFF30061E0038462F6A1301C01FC57F08830D001CE7656A1401C0CEE23F904106008ED58F5A4500B0A3F8F763700180E30DA46611007C59FC5F66500180368650BB0800BE28FEBD184C70B833AD3A061F691D34A2A06DE790F4F6DD47ED0BEA357657B73E13E27B0F9ABA7DC01B6F450E1B3D2F62D4A477C227CFFA3062F6A2B5514B3EDC1CB3627DF40E45FDB3FADFD4BF537F46FD59F5FF51FF5FF577A8BF4BFD9DEAEF56FF0DF5DF52FF4DDA1D0E378C1A46006848F1EFCE2042A04F3D6BD775645ACF01936343272E097F67F9969898C47D07F71DCA2A48CF29389257527AA6A8BCE26220A8FFB6FA19D4CFA27E26F5B3C9CF18A17E56F533CBCF7E92E787001B442D23007853FCBB587B4C1944B05DEBA0E0A28E3DC7EE1A387C56E4B4B92B23D66D894FDC9B96995F585671215005BEA1D4CFAE7E87B59BE392D4EF24BF5B94FC8EC9F2BB16F3CCE1479DA9690480FA14FF0E147FD8E47450AFB0A490F18BB72DFE60D3F6ED897BF767E5177DA66B91F796FA9DB727EC3D206D1013327E5184B4C92EBE56808DC7063F4D6D23007852FCFFCEF1BEF0A5369D46E40C0A9E15BEEAE3ED3B720A4B8E9B56EC3D955D587C62D586ED89EA4D81B4591E7D07BE0CDEE2CFD43802406DC5BF45CBCF6F9A62C0A0214E767E695CC2B4B92BC393F71FCEA4B87B67D7BE43D96FCE5911256D99246D7A8A7E85065237B6DE47AD23005457FC7FDCF2F3BBA61928A8B7673B85640E0E9913BE76735C426E51C9490AB86F499B9E5AB33176E7E0117322DB740AC9A6CFC14BA5E22E6A1E01A06AF1BF4964313850BF57FB21995367AF08DF7330238722ED5FBB0FA4E74D99BD3C8A30002FE4885BA87D040055FC9B896406053C15D42B2C71F5C731F1856515E729C681DE69507E61D586ED09EAAC02FA26EA61BFF83601C0ECE27FB9D8CC608027FBF1FB0D9B199198929A4AE175A684DDA987FA0D9B11C5F903F050BCF82601C0CCE2DF48BCC320401DFBF30BC64D7B7F4B7A6E411945560FE93905E5E3A62DDDA69E1D7D187558271A1300CC0B00E3E8FCA849FBEEA376BFB7726B544169F9198AAA9E0A4ACBCEBEB7626BB43CCB14FA346A3181006056F17F854E8F1A0A7F4A547C4A3205D45DD4332508A0169D08006614FFC7C5793A3C2EF1E9CCF9ABB7159655545230DDBA60B0A2523D63F5ACE9EFB8C459F17B0280BB8BFF5D0C7E5CAA47FFC9DB5333728B28926650CF5A3D73FA3E2EA1CE81B98300E0CEE27FAD48A393E3CB7DFC4123723FDA141B4F5134937AF6AA0F301670C9F6C0E604007715FFC662039D1B96736F8C991FCEB9FC507D40F505D5271817B0AC174D0800ACF887CB3CDF7DD4DE1DC907D2287EA84AF509D5371823B04C2200B8A3F8B7A7334319396171B8BAA39E82871A16095E089DB8389CB1024B170280DEC5FF7E6E118338B368D9C6288A1C3CB1F0FD8D6A81E019C60D3B03DCBE33C0CDC5FFBB8293C00CD7AA63F091CD5149BB286CA88FCD9149C9D2773E610C19AF50DC4800D0ABF85F619DF34C0736FAB6BE1159BBF61D4EA7A0C11B3BF71ECA943E94C35832DE56B71E17ECD60030974E6BF862BF1747EF4ACFE1FC7E34CCE1ECFC72E94B7B1853C60B2600E851FCDBD259CDD673C09488BC92D2931430F8426E51C9A99E0326C730B68CA64E8F7D8400E0ECE2FF23718CCE6AAEE163177C2C93F6790A177CBD43E0F5CFCF0B609C99AB54DC4C007066F16F2A76D249CDD5F7B5199B2956B0539FA1D33942D86CD1E2320280F302C0143AA7B9827A85EDE0EA5ED82DBFA4EC5CC75E63931973460B230038ABF83F45A73457DBCE216959F945472850F0878CBCC2A3CF760EC964EC19EB82789200E08CE2FF7D5141A734769F7FC9DEB4CC2C0A13FC29E56046BEF4BD72C6A0B18E885B0900812DFE4D04DFC999EB44F48E3DBB29480884F0D8E4039C346AB478DDD703E81E0042E984E66ECBF9604D4434850881B474D5B604EB953063D24CC308008129FE7FB5F666D2090D14F6E65256FCC311C64C79379A3169F47D01F71200FC5BFCAF1745743E33B5EF362AA5B0ACBC92E2032728282D3F2F7D3295B169ACFDEAF8790280FF02C0123A9DB937FB25EC3E7880C2032789DBB93F5DFAE639C6A7B1C61300FC53FC9FA4B3996BC4F845BCFA872305872DE4AB00B38F0AFE3D01C0DEE27F9D753D231DCE40CF760A49E78C7F38F8CE8033D247B93DD05CEA6C88660400FB02C0023A99B9876F6C89DE9944A181936D0C4FD8CB5835DA1C02803DC5FF713A97B9FA0F9BB98D02031DF47D6D462C63D6684F10007C5BFCBF25F2E958C69EF65794C951BFD0447A6EC131E9B3658C5D63A91D6ADF2600F82E00BC4DA732D7D4D9CBB75058A093496F7DC009A5665B4A00F04DF17F94CE64F4A7FF8A9CC2E2631415E8242BBFE8A4F4DDA38C61A33D46006858F16F2E72E948E61A396131DBFEA0A511E316B12DD06C19E22A0280F701E02D3A91D997FD1CCEC92FA1984047A999B9EAC6B8D38C63A38D24007857FC1FE0920DB30D0A9EB59542029D0D7CE3AD18C6B2D927978A9F1000EA57FC1B8B043A8FD1CEED4DCDCCA4884067C9FB0FE7736999F1B61100EA1700BAD069CCD66BE094480A08DCA0E780C93B18D3C66B4F00F0FCA6BF723A8CD936472525523CE0061F8727EC614C1BAF441D654F00A83B00CCA4B318BFF5AF98EB7EE1A6EB82A54FF3A1066F11006A2FFEF7F27D19060E9F154EE180CB1603723010D4A2F6160480EA8B7F23114727C1E6A8A49D140DB8EA92A088C414C636C46ED18400F0F5001044E740AB8EC125BCFE874BBF06E07E00283D08005F2DFED78A523A06060E9F1541C1802BBF06183E2B8A310EABD6352700FC3700BC49A7C07F5EFF472625532CE0469B22137733C661194500F8BCF8FF5454D221A08EFE2D282D3B47B1803BBF06283BA7FA38E31CE294F83E01A0C3F0957406281D7A8EE1D33F5CAD438F312C06C41716191D00A4011EA213E00BC1610BB75124E066C3C72E8864ACA3CAB6C07B4D0E000C067C69D586ED711409B8D98A7551498C7538E59E804016FFC779F8A89A86D3730A4A291270B3B4ACDC4F18EBB8C4DF8D0A00D6A13FAC88C597DA741A9141818009A4AFE731E651C50171994901A01D0F1D55F51E3495DBFF60845E03A7703B202EF5A21101407ED1A62293078EAA464D7A6733C501261839617134631ED5DC16D8CC8400D09B878D4B2D5AB68913006184F9EF6D8867CCA31A435C1D00E417BCC64A3A3C6C7C45786C321700C1089BA392F633E6510D7565F4356E0E00AFF390519DB4CCDC7C8A034CB0EF505639631E3518E8CA0020BFD8B7C4511E30AAF1994C8CE7290E30416159B9EAF36718F7A8612DC0D56E0C004378B8A8610B603A8501866D05CC67ECA3067D5C150054A2E1BA5FD4A46D979107280A3089F4797642A12645E24A3705809778A8A849FBEEA37653146092F6DD46A532F6518BDEAE0800F28B5C2E7279A0A8F116C01E6392280A30C90B3DC6EC63ECA316EA2BA22BDC10003AF230519B4EBDC3E2290A304950EF308E4247C04F07B4BBF83716BCEA42ADBAF5991043518049BABE326127631F75C8516FD0750E00CFF01051979E03A644511460921E03262730F6E1812E3A0700522EEAF4CA9069E1140598E4E5C16FC631F6E101F506BD917601407EE8477978F0C48037DEDA46518049FA0F9B19CBD887871ED3310044F2E0E089BEAFCDE00D008CD267E8F418C63E3CB44EAB00203FF0833C3478AA7BDF89B114059844FA3C6B00E0A90BE24E9D02C0221E1A3C3E07A0E798648A024CD2A1C79814C63EEA618A1601407ED01BC4691E183CD5AE6BE8418A024C227D9EEDD1A80F75915E331D02C0201E16EA170046A651146056001899C6D847A08F07B6E3E01F2EB90001002000C0B7D27CBD25D0D701E0091E120800000100CEDF12E8EB00B08E070402004000802DD63B3200C80F76BB38CF030201002000C0B62D813F76620018CBC30101002000C056931C1500E407BA4294F1604000000800B05599AF6E09F45500789E870202004000805F3CEDA40010CF030101002000C02FD6382200C80F72370F030400800000BF39276E74420018C9C30001002000C0AFFA39210070F21F0800000100FEB52FA001407E80DFF010400000080008885F0732004CE70180000010001010D3031200D43E44F6FE8300001000103047D4393C8108007FA7F1410000080008A856810800EFD1F02000000400E8794190B7C5FF1A718286070100200020A02AC50DFE0C00ED697410000002001C21C89F01E0631A1C04008000004758EB9700A08E1FB45E39D0E8200000040004DE69D1CC1F01A0338D0D0200400080A3B4F647005843438300001000E0284B6D0D00F21FB84A9CA4A14100000800709463F53D14A8BE01E0491A190400800000477AC2CE003087060601002000C091DEB62500C85FDC4814D1C020000004003892BA9FA7891D01E0011A17040080000047FBA31D012084860501002000C0D1A6DA110052685810000002001C2DC3A70140FEC25B69541000000200B470BB2F03402F1A1404008000002D74F16500D848838200001000A085653E0900F21735E5F43F1000000200B451AEB6EEFB2200FC8EC60401002000402BF7FA2200BC46438200001000A09581BE08005B68481000000200B4B2A9410140FE82CBC5091A120400800000ADA8B57B573424003C4C238200001000A0A53F3724000CA1014100000800D0D2A88604804D342008000001005A4AF02A0058DFFF1FA7014100000800D0D279D1CC9B00F0108D0702004000803BD701D416005EA5E14000000800D0DAABDE04808F69381000000200B4B6A25E01409D212C8ED2702000000400682DBFBE01E04E1A0D040080000057F85E7D02406B1A0C040080000057F8677D02C0581A0CFE0B00A107290A302B00841E64ECC38F46D72700700110FCE5CCFAAD3B92280A3089EAF3AAEF33FEE1275BEB13002A6830F8E3908A77576CDD4E41808954DFB70E6A612E80DDD4A2FE46750600F943B7D158F087E96FAFDA462180C9D418602E809FDCED4900F8370D05BB05872DDC4201002AFE33169813E0072F781200426928D8A96D97916905A5E5E798FC818A8B6A2CC89838C4DC009B4DF724006CA0A160A30B5BA277B2E80FA8627354523273036C16E9490028A1A16097DE83A64630E1035FD76BE09418E608D8A8B4D600207FE0161A0976AE444DCDCC2D60B207BEEE607A4E714BAE6087BDBE5D5B00789206825D42C62FDAC4440FD4BA20308AB90236FA6D6D0160200D04BBECDC7BE800933C50B31DC90732992B60A32EB50580D934106C5AF9CF71BF8007DA760EC962CE804D26D61600C26920D861CC94773733B903751B35E99D68E60CD864436D01209F06821D92F71FE6C63FC0038929A939CC19B04976B50140FEC5D56A8F360D045F6BD3694406133BE039193305CC1DB0E31C16F1CDEA02C0CF691CD821A8575802933AE0B98EBDC6A63077C026F7551700B80300B6E833743A87FF00F5F0CA90691C0A04BB3C575D00789586811D464E58CCAD7F403D848C5F14C9DC019B84561700DEA6616087398BD74632A9039E9BBDE8237602C02E1F54170038810AB658B331963500403DACD91893C8DC019BC45717008A6818D8615364E26E2675C0736ACC3077C026F95F0900F23F5C43A38000001000E07A95A249D500F00B1A05040080000023DC5235003C46838000001000608416550340071A040400800000233C53350070060008000001006678A56A00984C8380000010006084F15503C0521A040400800000232CAD1A0022681010000002008CB0BD6A0048A5414000000800304276D500F0290D02020040008011CE8AC6AAF85F4963800000100060941B5400B88D860001002000C0283F5201A0050D01020040008051EE5301E09F3404080000010046F9B30A005D690810000002008CF2B40A00FD680810000002008CD2510580D7690810000002008CD2470580B1340408000001004619AE02C0341A020400800000A34C5201603E0D01020040008051E6AB00B08C860001002000C0282B5400584B43800000100060946D2A0084D31020000004001865A70A00093404080000010046495501603F0D010200400080510EA900904D4380000010006094741500CA680810000002008C92A902C0091A020400800000A36411004000000800304F8E0A0047690810000002008C92A702C0111A020400800000A314B008100400800000F314A900504C43800000100060946215000A6808D869E5FAE81D4CEA80E73EDA149BC4DC019B95AA00904343C04E6FCE5D19C1A40E786EE1FB1B63983B60B3721500326908D86948C8DC702675C07313677E10C5DC019B1D5101E0300D013B757D65421C933AE0B961A3E7453377C066152A00A4D210B053DB2E235399D401CFF5E83F3991B90336CBE53640F8C33199D42E30B103752B2CABB8D8AA637039F3066C76500580141A02763B989193CBE40ED42D61772A37B4C21F125500D84543C06E13672CDBC2E40ED46DC6BCD57CFF0F7F08570180EF9A60BB369D46641696559C6782076AD7F9E5719C01007F58AB02402C0D017F58BF75473C133C50B35DFB0EAB73592E305FC00F96AA00B08186803F74EF3B3186491EA8D9ABC1B3D9FF0F7F99AB02C0BB3404FCE4DCC18C9C02267AE0EB32F20A8FC91839C13C013F99A202C0341A02FE121CB6602B933DC0E13F08B8501500426808F8F32DC0B698E414267CE0BFB627EE3D2463A392F9017E34580580BE3404FCA975D088FC8CDC82234CFC40C5C582D2B2CA765D430F3137C0CF5E5201A0030D017FEBD677223B02003172C2625EFD2310825400788A864020CC98B78A6B8261B4F9EF7DCC366C044A2B15007E474320404E47C4EDDE4B218089D66E8EDBA9D6C4300F20401E5701E01E1A02017472E9CA6DB1140498645364E26EE9FBC719FF08A0FB5500B8998640805D089DB824BCB08C1B03E17E33E7AF8EE1933F1CE0161500AEA221E0043DFA4F8ECD2D2A394991801BE5979456F67F7D661C631D4EF8D0252EFBC6C58B175508384D83C0099EEB167A202BBFE8330A06DC64C3B61D7BDB761999C518874394A8DAFF450028A441E014EFAF0E674D005C61DFA1ACA21EFD27EF605CC36176570D00FB69103845DFA1D3A3281ED0D9E6A89D7B7B0F9A1ACBDB5538D486AA0120820681734E0A0C2EA2884047AB366CDFF96CE7906CC6311CEEEDAA0160010D0227D9B1FB601A0505BA69D7752447FA420723AB068037681038C9C4991F845350A093F8E403E98C5D68A267D500F03C0D0227E9D873EC4E8A0A74F2FAE8F9918C5D68E25F5503C0EF691038CC99ECC262B603420B8565E5E75B070517336EA189165503C0F7691038CDCAF5D171141768B2CF3F99310B8DDC5A3500341667691438C9C037DEE2B64068E1E5C1D3B63366A191A65F06002B04B080058ED22668440EC5054E97535872B22517FB401FE55FD4FDAA0160330D03A7D9B5EF703A45064EB6E4C3CD318C556824B1BA0030878681D3BC3977C5368A0C9CACF34BE39218ABD0C8E2EA02C0101A064E2393EB0E8A0C9C2A2D33B754FA692563151A195A5D00684BC3C0814E65E41556506CE04453E7AC60EF3F74F3EFEA02C043340C9C68E682D57C0D00477AAE5BE841C62834F3B3EA02C04D340C9C4826D9BD141B384DD29EB40CC6273453F9C516C04B034023719206821325A6A4A65274E0248343E6708B2A7473E88B9AFF950060850056B3C2915E0B7D7B2B45074E919157F8297BFFA1A135B50580B934109CA855C7E0D282D2B233141F38C184E9CB58FC071D85D516007AD14070AA15EBA263293E08B4FC92B2735CFC034D05D516007E4B03C1A9BAF599400040C02D5AB63196F1084DFDA6B600D05C5CA091E050670F65E59550841048EDBA86A63116A1A9EB6A0C005608606B0B1C6BCAACE52C0644C07C1C9EB08771084D955C5AEFAB0B00CB69283855DB2E23D90E8880E9F2F2F89D8C43682AD29300308C8682936D4FD8BB8762047F4B4C49CD66FC4163533C09004FD25070B27EC366465090E06FFD86CD60F11F74D6D69300F07D1A0A0E772A2D33B798A2047F49CDCCFD44FADD69C61E34F6C33A038015022A682C38D9F0B10BB820087E133A71490CE30E1A2BABAED6D71400B6D16070B8A359F94547294EB05B4E61C999561D838F30E6A0B175F5090013693038DDF8E9EFF31600B69B3A7B39DFFD4377AFD727003C4F83C1E9E45359495E71E9298A146CBBF427B7E084F4B34F196FD0DCA3F509003FA6C1A083D98B3E8AA450C12EC1610BF9EE1FBABB70E90980B506002B0414D17070BA369D46641796955752ACE06BFB0F6797AB1D278C33682EADA63A5F5B00789F86830EDE5BB9358682059FEFFB7F6D461CE30B2EB0C89B00D09386830EDA750D3D48C1822F25EC3E98237DEB3CE30B2ED0D39B00700F0D075DACDB129F44E182AF74ED338133FFE116BFF626003412E5341E74F0C28BA353285CF085CD514907185370CBA9A9E2F27A07002B04ACA401A18B15EBA2E3296068A8E75F1C4D00805BC4D456E3EB0A00AFD080D0C5B39D43320A4ACBCF51C4E0AD656B2292184B7091110D0900F7D280D0C9AC859C0B00EFE49794554A88CC611CC1457ED79000D058700A16B43A1D30BBA0F838050DF5F5D682351CF90B3739262EF33A005821601D0D099D844E5CC21D01A897ACFCA293121ECB183F7091D575D5774F02C0401A129A399E9A915B446183A75E0D9ECD91BF3066FF7F7D02C083342474D36FD80CD602C0235BA377EEB7CE4B67ECC04DEEF44500B84C7DA2A231A199CAA43D69872970A84D6E71E999673B8764335EE0325975D5768F0280150256D3A0D04D9797C7EFA0C8A18EDBFEA2192B70A1D9BE0C0041342874F4FEEAF0ED143A542736695FBA7A53C438810B3DE3CB00F09D965C8C013DB7059666E4165450F05055416959E5735D430F3146E042AA565FE7B30060850056C9424B2F0F7E338AA287AAC64D5BCAAB7FB855BCA775BD3E0180ED80D0D6DACD71AC07C07FECDC7B489DF6779A7101138FFFF53600DC45C34257AD8346E46517167F4601345B6159F9C5177A8CD9C79880A9C7FF7A1500AC109046E34257AF06CFE68440C3CD98BF9AAF32E166E5751DFFDB900010460343E7C531E131C9C9144233ED4BCB2CE64C13B8DC9CFAD4F4FA0680876960E8ECD9CE21E97925A5A72888E6E9FCF2B85D8C01B8DC23760600753B60298D0C9D8D18B7680B05D12C13677EB09DBE0F5EFF3720005821601E0D0DCD9D8DDBB57F3F85D10C1B2312F772E00F0C30B7BEF5DC9B00F0140D0DDD3DD735747F4169F9390AA4BB1D389C5DD6AA6370397D1E0678D41F01E06A7192C686EE26CC58C657012E965F525AF9FC8BA30FD0D761808AFABEFEF72A00582160150D0E1738B9FB407A3AC5D29D5E1D313B963E0E43BCED4D2DF736003C4383C3155F05740BDDC7AE00F759F2E1E644FA370CF2983F03C015E2088D0E3718F0C65BE1144DF7884F3E90C5D7943088AAC597FB2D00582160260D0FB7904F8C5C1BEC02197985279EED1C924B9F8641E6795BC71B12005AD0F07091E38929A91914519DCFF9AFB8D8BDEF440EFB81691EF77B00E06E00B8F094C0CCFC9232B6066A6AEAECE52CFA83693EF1F6F5BF2F02C0501E00DC2423AFF028C5544FBD074DDD411F86616637A486373400FC405CE0218000000200E077F7072C005821601B0F010400100000BF4A6968FDF645007881070102000800805FF5764200B8A625776C8300000200E02FA7C475010F00560858C4030101000400C02F96F8A276FB2A00FC95070202000800805FFCD14901A0B1E0F42D1000400000EC75C81775DB67018033014000000100F08B414E0C00FF632D4CE0018100000200E07BE7C48D8E0B00560898C7030201000400C0162B7C59B37D1D007EC9030201000400C0168F3B360058212092870402000800804FA985F68D9D1E009EE6418100000200E053037D5DAFED08004D44360F0B04001000009F382ABEE5F800608580013C3010004000007C629C1DB5DAAE00709D38C1430301000400A041CE8A5BB40900560898C9830301000400A04116DA55A7ED0C0077F3E0400000010068907BB40B005608D8C4C30301000400C02BEBEDACD1760780277880200080000078E54F3A078046229987080200080040BD24DA599F6D0F005608F8270F1204001000807A69E58600C05B0010004000003C97A10ED5D33E00F0160004001000807AE9E98FDAECAF00C05B001000400000EA562CAE764D00E02D0008002000001EE9EDAFBAECCF00C05B0010004000006A96239ABA2E00F0160004001000805A05F9B326FB3B00F016000400100080AF4BF3C7CAFF800500DE02800000020050AD36FEAEC7810800BC058063E515979EA6986A1B00E2E9C3D0548AAA8DAE0F00BC0580839DA490EAABFFEB3363E8C3D0D49381A8C5810A00EA2D40020F1D4ED23A28B89842AAAFE0B085D1F46368282E1075386001C00A010FF3E0E1246DBB8C3C4C21D5D7A4991F1000A0A3BF181700AC10F03E0F1F4ED1A977581285545F6FBFB33E967E0CCD6C0D640D0E7400B8559CA213C00982C316865348F5B57EEB8E14FA3134D3C2D800608580503A019CE0C38F22E329A4FACAC82D382ECFF1027D199A5819E8FAEB8400708D28A23320D0F61FCE2EA490EAEDD9CE21D9F4656840BDF9BEDDF800608580203A0402A94DD0883C0AA8FE5E1E3C2D8EFE0C0D0C7742ED754A00682C76D12910286F8C5D104101D5DFDC25EB080070BA2C711501E0AB21E00F740C044ADCAEFD691450FDA5E7161C95E779863E0D07FB9753EAAE630280150296D339E0F7FDFF9D43D2299EEED1BDDF44EE0480536D7452CD755A00B8439CA693C09FA6CC5ECEEB7F1759BE36923B01E04467C55D0480DA43C0583A0AFCA555C7E092DCA212EE007091FC92B233F25C8BE9DF709830A7D55B270680E66C0B84BFBC3977651445D37D66CE5F1D41FF868314A82DEF0400CF42C0D37418D8AD755070917CFAE7FA5F77BE0538DBA6D3883CFA391CA29D136BAD23038015023EA4D3C0E693FF122996EEB5F0FD8D6C0984134439B5CE3A3900DC248ED079608757864C8BA548BA5B4169F985E75F1CBD9FFE8E00AA14BF20007817023AD081E0FB57FF230A33F30A3FA348BADF9ED48CC2561D871FA3DF83857F9A05002B046CA213C1874E6F89DEB98FE2688E77966F49A0DF23000E8A2B09000D0B00B789E37426F8C0F9656B22765014CDD3F7B519B1F47FF873AE6919E0AB7E5D1100AC10F0121D0A0D3573C11AB6FC99BB2BE05C9797C7EF641C8057FFFA0500755910091EDEBA307EFAFB9CF66738B5E5B343CF317B180F30FDD5BF5601C00A017773C907BC7072E9CA6DACF8C77F64E5179D68DF7DD441C6054C7EF5AF5D00B042C0303A18EA73CC6F547C0A0BFEF015398525A77A0D9CC27D0130F6D5BFAE01E072914227435DBAF59D187F3023A79882879A4C9EF561B4B54F9B3103A35EFD6B1900AC10F02BBE0A408D7BFC3B06172F5B131147818327364624A67064304C7BF5AF6D00B042401F3A1C2E71F6D5E0D9911979859F52D850AFC581C5A567C64E7D2F4AFAD009C6114C78F5AF7B006824D6D3E9A0F4E83F3976F781C3D9143334C4FE435945BD064E51F7075C605CC1CDAFFEB50E005608F84E4BAE0D36DA0B3DC6A444B2C80F3EB623F9607A8FFE93E20902F0E4CDA3B85FD73AAA6D00B042C0230C52F33CDB392463C5FAE8048A15080208B03E3AD750AD03801502C2E884E62CF09BB3786D5441697925050A040104D86ADDEBA71B0280DA1A98486774B5CFC64C79373CA7B0E4040509040138408EB89E00E08C10F023C1959F2EFC7E6D50F0ECC843D979E514201004E010E7C4436EA89DAE08005608684FC774D3CAFE4971ACEC0741000E34C02D75D33501C00A018BE99CACEC070802B0C93AB50D9D00E0CC00D04CA4D34959D90F1004E063EAC4C81BDC54335D1500AC10F06B719ACEAAC9CAFEA0E092398BD746B3B21F04013898BA33E2B76EAB97AE0B005608E84087D562657F042BFB4110800686B8B156BA3200582160129DD6B92BFBD3B258D90F7382C08B04019D6D74D3F7FEA6048026620B9DD7592BFB93F7B3B21F0401E6036D64BAED7B7F2302801502AE171974E2C0AFEC8F88DBCDCA7E8020A01375B6CCCFDC5C235D1D00AC10708FFABE99CECCCA7E8020000F9D174FB8BD3EBA3E005821E05F0C3256F603040178A8BF09B5D1880060858037E8D4FE59D99F5D58CCCA7E8020A0ABF9A6D44593024023B182CE6DCFD9D8ACEC0708022EB05D342500B833045C23F6D2C97DE7C57E93E259D90F10045C205BFC8F4935D1A8006085803B44059DBDC12BFBF7B0B21F2008B8E5EB4BF1BFA6D543E302801502FE24CED0E9BD5AD99FB9625D142BFB0182809B56FCFFC3C45A686400B042402BEBC133003C59D9DF9195FD806382403F82800F0D32B50E1A1B00AC10D093CE5FA7E3ACEC0708022E35CFE41A687400B042400883A08695FDC36745B1B21F707C10384C10F0CA2A75643C0180103087C1C0CA7E8020608C7071A5E9B58F00F0DF8B8356B1B27FCC9EC8B8DDFB994C0182808BED14CDA97D0480AA21E04A11CDCA7E000401D74A336DAF3F01C0F31070AD490705A995FDB317B1B21F200818214FFC805A4700A82D04DC2C725CBFB27FF2BB91ACEC0708028628177753E308009E8480BBAC0EC3CA7E000401FD4FF9BB9FDA4600A84F0878D0EA38AE59D9BF6B1F2BFB01181504D489AF7FA1A61100BC09010F8B637AAFEC1FADCEEC67653F80DA82409C0B8340A5F837B58C00D09010F01B1D43805AD9BF9C95FD00CC0C02EA98F70ED43002802F42C043E2A85E2BFBCB58D90FC0C420A03EF93F47ED2200F83204B470780860653F00D383C039D19A9A4500B06B61E0A74EEBF003D5CAFECC5C56F603B021081C38A44910382B9EA6561100EC0C010F382504B0B21F0041E0CBD5FE4F52A30800FE0801F78B4F58D90F80201070A7C4DFA84D04007F86805F8B23ACEC0740100858F13F29FE8F9A4400084408B8CF1F218095FD0008025F5FF82CFE482D2200043204FC4A94D8D5C1474F7E8795FD0008025FA5CE66F92D358800E08410F04371C8971DBC47FFC9710733724A995800E81604BAF599B0C3C6E2AFD65FB5A0F610009C14026E10F10D7EDD1F34A260F5C731894C240074B67EEB8E5D6D3B8764F8B8F8AB9B5A7F4ACD21003831045C2DD6787B7AD5D0917323B20B8B8F3379007083FC92B27353662F8F6AD5D127C7A9278BEF516B08004E0E014DC45BF5E9D8EDBA861ED89EB8976D7D005C292D33B7A2CFD0E9B10D581FB05134A3C61000740902433DE9D8C346CF8B28282D3FC72401C0ED22E353D29EEB165ADFF552F3C465D41502806E21E079EB78CAEA3AF58977576C8D65520060D6D702A5E7068F9813EB61F11F4E2D2100E81C021EB9F43AE1369D46E4C5EF3A7098C90080A996AEDC9668EDE5AFE9529F206A0801C02D670514AA8EDDA97758727A6EC1A74C00004CB76BDFA1DC765D461EAE668FFFA3D40E02809B42C0AD23272C5E5B505A7E9E810F009FCB292C39652D10BC687D50FA15358300E03AD2D96F159CE50F009798B364DD2A29FE3FA0561000DC1C02AE103319F000F0A5B5E23A6A0401C09420D05E70C63F0093A90BCE068B46D40502806921E07FC521260100062A167FA21610004C0E01CDC572260300068914DFA5061000F07910E82F381110809B5D10630527FB1100704908F8BD28629200E0429F88A798EB0900A83904DC64BD1E63C200E016BBC41DCCF10400D41D022E13E3983400B8C06C7125733B0100F50B024F8BA34C200034A4B6393FCF5C4E0080F721E04EB187C9048046D2C43DCCE10400343C045C2D1631A900D0C032D18CB99B0000DF0681EEE234130C00073A2B5E62AE2600C0BE10F04B6B452D130E00A7C8112D98A30900F0CF2E8141E214130F800052D79B4FE3953F010081592018C124042000F68987988B0900085C086824BA8A4F999000F8815A87344C34650E2600C01941E066B19AC909808DA2C44F9873090070661068254A98A800F8907AC3D84DBD71649E2500C0D921E07AB180490B800FA8EBCAB9BA970000CD82C023228B090C8017F2C53F994B0900D037047C534CB6B6EB30A901A8CB05314334670E2500C01D41E0416BDB0E131C809A1C100F33671200E0BE10D054BC21CE30D101A842CD09C3D9DA470080FB83C0CF441C931E00B15DDCCDDC4800803921A0B1784E64320102462AB12E18636B1F0100860681CB454F51CC840818E11331542D10660E2400005FEC1618CA91C2806B9D10A3C575CC792000A0A64384C2C449264CC0350BFCDE143731C78100004FEF169825CE3181025AAAB44E04BD8D390D0400787BE5F052EB70102655400F1FB2B21F0400F82A08FC4A6C6062051C6DA3B88F390B0400D81104FE20629968014789516393390A0400F82308FC43EC65E205026AB778823909040004E230A1F6DC3808F8DD21D186437C40008013EE18E8C6654380ED3244677119730F0800705A18F89358616D4162C2067C733DEF7AF1B87AEBC63C0302009C1E04BE2F4689322670C0EB237B27881F32A78000001D83C015E20591C8840E78BCB0AF8BB89A39040400B8250CB4104BACA34999E881FF3A6B1DB8F55BE60A1000E0E62070A318260A98F861B842F186F82E730308003029085C265A89280A010CA3FA7C6B751D3773010800303D0CFC42CCB1AE2CA540C0ADD7F1CE163F67CC8300007C3D085C27FA59FB9D291A7083C3A28FB896310E020050771068642D1A1C471880868AC44CF1174EEB030100685820F8A5081107282E70A82C6BDFFEC31CD8030200604F18F889182A76517410602A908E54D7653336410000FC1B066EB7D60CC45A47A6529460B72431440551C62008008033C2C0F7444FB18DBB08E043E745B4B590EF56C61A080080B3C3C00DA29375890A270FC29B93F9365AB75CDEC898020100D0330C7C4BB4B36E29FC8CE2861A9C14ABC4F36A3B2A63070400C07DA70FAAED8583AD4F78C7297CC62A162BC5006BE5FE958C111000007302C1E5D6E4AF76156CB13E05521CDDA7D2BA656F86784EDC41FF0701804600AA0682A6E277D665451B4419C5534B9F58CF6F987518CF35F46F800000D43714DC265A8AB1D60E83A314584751DB3F53C53CD159FC94D3F700020060D731C57759AF92A788181617FA956AEB70112A9E10D7D32F01020010C860708BF83FD15B4CB7DE161452B0BD5668B5A1FADEFE25F188F8019FEE010200A0D336C407C50B628C582E124589E1A7175EB056E227596D32CADA82F780684EDF010800809BC3C115E287E24F56F17B4DCCB20E30DAA7F97A830A6BE5FD47D6A7F8C1D6D7267F50ABF0D5EF4E1F000800006ADFAAF81DEB12A487C4E35621555F35BC2E268985628D88B0EE45509FAA53C441912E72AC2B6ACBC53171CA3AE2F6BCF5CFC7AC7F5764FDD974EBA29B14EB6D45ACF5BDBB3A2867BE9868851575F4F2B3E231EB2DC79DD6298C4D787680B3FD3F6A5B61BFA2D238BD0000000049454E44AE426082);

-- ----------------------------
-- Table structure for `tbl_bloodbanking`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_bloodbanking`;
CREATE TABLE `tbl_bloodbanking` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `service` varchar(255) default NULL,
  `bloodbankingid` varchar(255) default NULL,
  `bloodbagserialnumber` varchar(255) default NULL,
  `bloodcomponent` varchar(255) default NULL,
  `donorcontrolnumber` varchar(255) default NULL,
  `donorabobloodtype` varchar(255) default NULL,
  `donorrhbloodtype` varchar(255) default NULL,
  `patientabobloodtype` varchar(255) default NULL,
  `patientrhbloodtype` varchar(255) default NULL,
  `immediatespinphase` varchar(255) default NULL,
  `enchancementmediaphase` varchar(255) default NULL,
  `antihumanglobulinphase` varchar(255) default NULL,
  `autocontrol` varchar(255) default NULL,
  `othertest` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_bloodbanking
-- ----------------------------
INSERT INTO `tbl_bloodbanking` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'ER', 'CT - 1', '1920-000476-1', 'Whole blood', 'NA', 'NA', 'Positive', '\"o\"', 'Positive', 'COMPATIBLE', 'COMPATIBLE', 'COMPATIBLE', 'COMPATIBLE', '', 'August 01, 2016');

-- ----------------------------
-- Table structure for `tbl_clinicalchem_conventionalvalues`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_clinicalchem_conventionalvalues`;
CREATE TABLE `tbl_clinicalchem_conventionalvalues` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `service` varchar(255) default NULL,
  `clinicalchemid` varchar(255) default NULL,
  `glucose` varchar(255) default NULL,
  `ureanitrogen` varchar(255) default NULL,
  `creatinine` varchar(255) default NULL,
  `uricacid` varchar(255) default NULL,
  `triglycerides` varchar(255) default NULL,
  `cholesterol` varchar(255) default NULL,
  `hdl` varchar(255) default NULL,
  `ldl` varchar(255) default NULL,
  `sgpt` varchar(255) default NULL,
  `sgot` varchar(255) default NULL,
  `sodium` varchar(255) default NULL,
  `potassium` varchar(255) default NULL,
  `chloride` varchar(255) default NULL,
  `remarks` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_clinicalchem_conventionalvalues
-- ----------------------------
INSERT INTO `tbl_clinicalchem_conventionalvalues` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'Out - Patient', 'CC - 1', '99.0', '16.8', '0.9', '3.6', '30', '200', '30', '60.23', '41', '38', '135', '3.5', '98', 'NA', 'August 02, 2016');

-- ----------------------------
-- Table structure for `tbl_clinicalchem_svalues`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_clinicalchem_svalues`;
CREATE TABLE `tbl_clinicalchem_svalues` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `service` varchar(255) default NULL,
  `clinicalchemid` varchar(255) default NULL,
  `glucose` varchar(255) default NULL,
  `ureanitrogen` varchar(255) default NULL,
  `creatinine` varchar(255) default NULL,
  `uricacid` varchar(255) default NULL,
  `triglycerides` varchar(255) default NULL,
  `cholesterol` varchar(255) default NULL,
  `hdl` varchar(255) default NULL,
  `ldl` varchar(255) default NULL,
  `sgpt` varchar(255) default NULL,
  `sgot` varchar(255) default NULL,
  `sodium` varchar(255) default NULL,
  `potassium` varchar(255) default NULL,
  `chloride` varchar(255) default NULL,
  `remarks` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_clinicalchem_svalues
-- ----------------------------
INSERT INTO `tbl_clinicalchem_svalues` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'Out - Patient', 'CC - 1', '3.89', '2.8', '80', '214', '0.34', '5.2', '0.774', '1.56', '41', '38', '135', '3.5', '97', 'NA', 'August 02, 2016');

-- ----------------------------
-- Table structure for `tbl_clinicalrecord`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_clinicalrecord`;
CREATE TABLE `tbl_clinicalrecord` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `ht` varchar(255) default NULL,
  `wt` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `occupation` varchar(255) default NULL,
  `contactnumber` varchar(255) default NULL,
  `chiefcomplaint` text,
  `hpi` text,
  `htnmeds` varchar(255) default NULL,
  `dmmeds` varchar(255) default NULL,
  `asthmameds` varchar(255) default NULL,
  `allergymeds` varchar(255) default NULL,
  `sxmeds` varchar(255) default NULL,
  `chiefcomplaintother` varchar(255) default NULL,
  `diagnosis` varchar(255) default NULL,
  `ermanagement` varchar(255) default NULL,
  `bp` varchar(255) default NULL,
  `cr` varchar(255) default NULL,
  `rr` varchar(255) default NULL,
  `temp` varchar(255) default NULL,
  `heent` varchar(255) default NULL,
  `lungs` varchar(255) default NULL,
  `heart` varchar(255) default NULL,
  `abdomen` varchar(255) default NULL,
  `genitouro` varchar(255) default NULL,
  `extremities` varchar(255) default NULL,
  `neuro` varchar(255) default NULL,
  `vitalsignother` varchar(255) default NULL,
  `meds` varchar(255) default NULL,
  `residentonduty` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_clinicalrecord
-- ----------------------------
INSERT INTO `tbl_clinicalrecord` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', '1996-09-15', '5\'7', '120', '173 Aida St. Marick Sub Cainta Rizal', 'PBA Player', '090 952-13367', 'Ferver', '2 days', '', '', '', '', '', '', 'Dengue', 'Ancillary', '120/80', '80', '8', '80', 'Weak', 'Weak', 'Weak', 'Weak', 'Weak', 'Weak', 'Weak', '', null, 'Dr. Menes', '05:53:57 PM', 'August 10, 2016');
INSERT INTO `tbl_clinicalrecord` VALUES ('44', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', '1996-09-15', '5\'7', '120', '173 Aida St. Marick Sub Cainta Rizal', 'PBA Player', '09095213367', 'Nag tatae', '3 days na', '', '', '', '', '', '', 'Nahihilo. 2 days na', 'Not a necessary', '120/80', '50', '80', '39', 'Weak', 'Normal', 'Normal', 'Normal', 'Normal', 'Normal', 'Normal', 'Normal', '', 'Dr. Menes', '09:29:22 AM', 'September 17, 2016');
INSERT INTO `tbl_clinicalrecord` VALUES ('45', '9172016 - 3', 'De leon', 'Chadwick', 'Urbina', '17', 'Male', '1999-04-27', '5\'7', '80', '176 flora st. Marick Sub. Cainta Rizal', 'Police', '090 952-13367', 'masakit ang katawan', '3 days na', '', '', '', '', '', '', 'Baka pagod lang', 'Not necessary', '120/80', '50', '50', '39', 'Normal', 'Normal', 'Normal', 'Normal', 'Normal', 'Normal', 'Normal', '', '', 'Dr. Menes', '10:38:27 AM', 'September 17, 2016');
INSERT INTO `tbl_clinicalrecord` VALUES ('46', '9172016 - 4', 'Decastro', 'Lara', 'Urbina', '17', 'Female', '1999-09-17', '5\'1', '70', 'Esla dahodine', '', '090 952-13367', 'Di nawawala sakit ng ulo', '1 week na', '', '', '', '', '', '', 'Dengue', 'Observing', '120/80', '50', '50', '39', 'normal', 'weak', 'weak', 'normal', 'normal', 'normal', 'normal', 'none', 'biogesic', 'Dr. Menes', '10:55:24 AM', 'September 17, 2016');
INSERT INTO `tbl_clinicalrecord` VALUES ('47', '9172016 - 5', 'Urbina', 'Jasper', '', '15', 'Male', '2001-09-17', '5\'5', '90', 'Aida st. Marick Sub. Cainta Rizal', '', '090 952-13367', 'nag tatae', '5 days na', null, null, null, null, null, null, null, null, '120/70', '60', '70', '37', null, null, null, null, null, null, null, null, null, 'Dr. Menes', '11:03:05 AM', 'September 17, 2016');
INSERT INTO `tbl_clinicalrecord` VALUES ('48', '9172016 - 6', 'Menes', 'Daniel Anthony', 'Dela Cruz', '21', 'Male', '1994-10-02', '5\'7', '120', 'Riverside Cainta,Rizal', 'Designer', '091 655-53055', 'joint pain', '1 week', null, null, null, null, null, null, null, null, '120/80', '80', '80', '36.5', null, null, null, null, null, null, null, null, null, 'Dr. Oriina', '02:14:32 PM', 'September 17, 2016');
INSERT INTO `tbl_clinicalrecord` VALUES ('49', '9202016 - 7', 'Dino', 'Norman', 'Avelaneda', '56', 'Male', '1960-09-20', '5\'8', '120', 'Cainta, Rizal', 'Professor', '099 581-56433', 'ferver', '2 days', null, null, null, null, null, null, null, null, '120/60', '60', '80', '39.2', null, null, null, null, null, null, null, null, null, 'Dr. Menes', '07:41:21 PM', 'September 20, 2016');

-- ----------------------------
-- Table structure for `tbl_ctscanpendingcheckup`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ctscanpendingcheckup`;
CREATE TABLE `tbl_ctscanpendingcheckup` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ctscanpendingcheckup
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_ctscanresult`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ctscanresult`;
CREATE TABLE `tbl_ctscanresult` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `ctscanresult` text,
  `physician` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ctscanresult
-- ----------------------------
INSERT INTO `tbl_ctscanresult` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Wala naman na detect na symtoms', 'Dr. Menes', '12:07:33 AM\r\n', 'August 03, 2016\r\n');
INSERT INTO `tbl_ctscanresult` VALUES ('8', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '56', 'Male', 'weak', 'Dr. Perez', '07:53:58 PM', 'September 20, 2016');

-- ----------------------------
-- Table structure for `tbl_discharge_transaction`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_discharge_transaction`;
CREATE TABLE `tbl_discharge_transaction` (
  `transactioncount` int(11) NOT NULL auto_increment,
  `transactionid` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `wardtype` varchar(255) default NULL,
  `dateadmitted` varchar(255) default NULL,
  `timeadmitted` varchar(255) default NULL,
  `datedischarge` varchar(255) default NULL,
  `timedischarge` varchar(255) default NULL,
  `otherfeetotal` int(255) default NULL,
  `totalstayamount` varchar(255) default NULL,
  `overallamountdue` int(11) default NULL,
  `discount` varchar(255) default NULL,
  `amountpaid` varchar(255) default NULL,
  `changed` varchar(255) default NULL,
  `billingstatus` varchar(255) default NULL,
  `user` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`transactioncount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_discharge_transaction
-- ----------------------------
INSERT INTO `tbl_discharge_transaction` VALUES ('1', '09172016123525', '9172016 - 2', 'De leon ', 'Chadwick ', 'Urbina', 'Medical Male Ward', '2016-09-17', '12:23:17 PM', '2016-09-17', '12:35:25 PM', '0', '50', '50', '0', '50', '0', null, 'Menes', '12:35:25 PM', '2016-09-17');
INSERT INTO `tbl_discharge_transaction` VALUES ('2', '09172016123544', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', 'Medical Male Ward', '2016-09-17', '12:03:35 PM', '2016-09-17', '12:35:44 PM', '0', '50', '50', '10', '50', '10', null, 'Menes', '12:35:44 PM', '2016-09-17');
INSERT INTO `tbl_discharge_transaction` VALUES ('3', '09202016073451', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', 'Medical Male Ward', '2016-09-17', '07:03:45 PM', '2016-09-20', '07:34:51 PM', '1200', '150', '1350', '0', '1350', '0', 'Indigent patient and paid by PSCO Cause for being Indigent.unemployed', 'Menes', '07:34:51 PM', '2016-09-20');
INSERT INTO `tbl_discharge_transaction` VALUES ('4', '09222016080401', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', 'Medical Male Ward', '2016-09-20', '07:47:55 PM', '2016-09-22', '08:04:01 PM', '1800', '100', '1900', '380', '1900', '380', null, 'Menes', '08:04:01 PM', '2016-09-22');
INSERT INTO `tbl_discharge_transaction` VALUES ('5', '09202016095643', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', 'Medical Male Ward', '2016-09-20', '01:31:17 AM', '2016-09-20', '09:56:43 PM', '0', '50', '550', '58120', '550', '0', null, '', '09:56:43 PM', '2016-09-20');

-- ----------------------------
-- Table structure for `tbl_discount`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_discount`;
CREATE TABLE `tbl_discount` (
  `discount` varchar(5) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_discount
-- ----------------------------
INSERT INTO `tbl_discount` VALUES ('0.20');

-- ----------------------------
-- Table structure for `tbl_doctor`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_doctor`;
CREATE TABLE `tbl_doctor` (
  `doctorcount` int(11) NOT NULL auto_increment,
  `doctorid` varchar(255) default NULL,
  `doctorname` varchar(255) default NULL,
  `department` varchar(255) default NULL,
  `doctorstatus` varchar(255) default NULL,
  PRIMARY KEY  (`doctorcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_doctor
-- ----------------------------
INSERT INTO `tbl_doctor` VALUES ('1', 'DC - 1', 'Dr. Menes', 'Nephrology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('2', 'DC - 2', 'Dr. Cruz', 'Internal Medicine', 'Available');
INSERT INTO `tbl_doctor` VALUES ('4', 'DC - 3', 'Dr. Jeciel', 'Internal Medicine - Adult Cardiology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('5', 'DC - 4', 'Dr. Perez', 'Internal Medicine - Pulmonology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('6', 'DC - 5', 'Dr. Oriina', 'Pediatrics', 'Available');
INSERT INTO `tbl_doctor` VALUES ('7', 'DC - 6', 'Dr. Santiago', 'Pediatrics', 'Available');
INSERT INTO `tbl_doctor` VALUES ('8', 'DC - 7', 'Dr. Gongora', 'Psychiatry', 'Available');
INSERT INTO `tbl_doctor` VALUES ('9', 'DC - 8', 'Dr. Mendoza', 'OB - Gynecology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('10', 'DC - 9', 'Dr. Siodina', 'OB - Gynecology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('11', 'DC - 10', 'Dr. Paragas', 'Surgery', 'Available');
INSERT INTO `tbl_doctor` VALUES ('12', 'DC - 11', 'Dr. Culangen', 'Surgery', 'Available');
INSERT INTO `tbl_doctor` VALUES ('13', 'DC - 12', 'Dr. Nieto', 'Orthopedic Surgery', 'Available');
INSERT INTO `tbl_doctor` VALUES ('14', 'DC - 13', 'Dr. Recidoro', 'Urology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('15', 'DC - 14', 'Dr. Madrid', 'Ophthalmology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('16', 'DC - 15', 'Dr. Trinidad', 'ENT', 'Available');
INSERT INTO `tbl_doctor` VALUES ('17', 'DC - 16', 'Dr. Jarin', 'ENT', 'Available');
INSERT INTO `tbl_doctor` VALUES ('18', 'DC - 18', 'Dr. Pena', 'Oncology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('19', 'DC - 19', 'Dr. Medina', 'Nephrology', 'Available');
INSERT INTO `tbl_doctor` VALUES ('20', 'DC - 20', 'Dr. Tolentino', 'General Medicine (OPD)', 'Available');

-- ----------------------------
-- Table structure for `tbl_doctorprice`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_doctorprice`;
CREATE TABLE `tbl_doctorprice` (
  `doctorprice` int(11) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_doctorprice
-- ----------------------------
INSERT INTO `tbl_doctorprice` VALUES ('500');

-- ----------------------------
-- Table structure for `tbl_ecgpendingcheckup`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ecgpendingcheckup`;
CREATE TABLE `tbl_ecgpendingcheckup` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ecgpendingcheckup
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_ecgresult`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ecgresult`;
CREATE TABLE `tbl_ecgresult` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `ecgresult` text,
  `physician` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ecgresult
-- ----------------------------
INSERT INTO `tbl_ecgresult` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Getting Better and Better', 'Dr. Menes', '12:45:21 AM', 'August 03, 2016');
INSERT INTO `tbl_ecgresult` VALUES ('8', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '56', 'Male', 'walang lungs', 'Dr. Perez', '07:54:12 PM', 'September 20, 2016');

-- ----------------------------
-- Table structure for `tbl_emergency`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_emergency`;
CREATE TABLE `tbl_emergency` (
  `ercount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `ht` varchar(255) default NULL,
  `wt` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `causeofincident` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  `roomnumber` varchar(255) default NULL,
  `status` varchar(255) default NULL,
  PRIMARY KEY  (`ercount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_emergency
-- ----------------------------
INSERT INTO `tbl_emergency` VALUES ('1', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '1994-10-02', '21', 'Male', '5\'7', '120', '091 655-53055', 'Riverside Cainta,Rizal', 'cough and fever', 'September 17, 2016', '07:00:37 PM', '1', 'In Er room');
INSERT INTO `tbl_emergency` VALUES ('2', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '1960-09-20', '56', 'Male', '5\'8', '120', '099 581-56433', 'Cainta, Rizal', 'a', 'September 18, 2016', '09:20:13 PM', '1', 'In Er room');
INSERT INTO `tbl_emergency` VALUES ('3', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '1994-10-02', '21', 'Male', '5\'7', '120', '091 655-53055', 'Riverside Cainta,Rizal', 'aa', 'September 18, 2016', '09:22:10 PM', '2', 'In Er room');
INSERT INTO `tbl_emergency` VALUES ('4', '9172016 - 4', 'Urbina  ', 'Jasper  ', 'Sayson', '2001-09-17', '15', 'Male', '5\'5', '90', '090 952-13367', 'Aida st. Marick Sub. Cainta Rizal', 'x', 'September 18, 2016', '09:23:48 PM', '3', 'In Er room');

-- ----------------------------
-- Table structure for `tbl_erroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_erroom`;
CREATE TABLE `tbl_erroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `erroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_erroom
-- ----------------------------
INSERT INTO `tbl_erroom` VALUES ('1', 'ER - 1', '1', 'Taken');
INSERT INTO `tbl_erroom` VALUES ('2', 'ER - 2', '2', 'Taken');
INSERT INTO `tbl_erroom` VALUES ('3', 'ER - 3', '3', 'Taken');
INSERT INTO `tbl_erroom` VALUES ('4', 'ER - 4', '4', 'Available');
INSERT INTO `tbl_erroom` VALUES ('5', 'ER - 5', '5', 'Available');
INSERT INTO `tbl_erroom` VALUES ('6', 'ER - 6', '6', 'Available');
INSERT INTO `tbl_erroom` VALUES ('7', 'ER - 7', '7', 'Available');

-- ----------------------------
-- Table structure for `tbl_ertransfer`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ertransfer`;
CREATE TABLE `tbl_ertransfer` (
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `occupation` varchar(255) default NULL,
  `philhealth` varchar(255) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ertransfer
-- ----------------------------
INSERT INTO `tbl_ertransfer` VALUES ('9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '2016-09-17', '21', 'Male', 'Riverside Cainta,Rizal', '091 655-53055', 'Designer', 'With Philhealth');

-- ----------------------------
-- Table structure for `tbl_erward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_erward`;
CREATE TABLE `tbl_erward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `occupation` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `cause` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `philhealth` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_erward
-- ----------------------------
INSERT INTO `tbl_erward` VALUES ('2', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '56', 'Male', '1960-09-20', '099 581-56433', 'Cainta, Rizal', 'Professor', 'September 18, 2016', '09:20:13 PM', 'a', '1', 'With Philhealth');
INSERT INTO `tbl_erward` VALUES ('3', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '21', 'Male', '1994-10-02', '091 655-53055', 'Riverside Cainta,Rizal', 'Designer', 'September 18, 2016', '09:22:10 PM', 'aa', '2', 'With Philhealth');
INSERT INTO `tbl_erward` VALUES ('4', '9172016 - 4', 'Urbina  ', 'Jasper  ', 'Sayson', '15', 'Male', '2001-09-17', '090 952-13367', 'Aida st. Marick Sub. Cainta Rizal', 'Driver', 'September 18, 2016', '09:23:48 PM', 'x', '3', 'Without Philhealth');

-- ----------------------------
-- Table structure for `tbl_er_discharge`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_er_discharge`;
CREATE TABLE `tbl_er_discharge` (
  `patientdischargecount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `birthdate` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `occupation` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `timebrought` varchar(255) default NULL,
  `datebrought` varchar(255) default NULL,
  `timedischarge` varchar(255) default NULL,
  `datedischarge` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `bedfee` varchar(255) default NULL,
  PRIMARY KEY  (`patientdischargecount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_er_discharge
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_fecalysis`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_fecalysis`;
CREATE TABLE `tbl_fecalysis` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `service` varchar(255) default NULL,
  `fecalysisid` varchar(255) default NULL,
  `color` varchar(255) default NULL,
  `consistency` varchar(255) default NULL,
  `parasites` varchar(255) default NULL,
  `leukocytes` varchar(255) default NULL,
  `erythrocytes` varchar(255) default NULL,
  `fatglobules` varchar(255) default NULL,
  `starchgranules` varchar(255) default NULL,
  `occultblood` varchar(255) default NULL,
  `remark` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_fecalysis
-- ----------------------------
INSERT INTO `tbl_fecalysis` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'ER', 'F - 1', 'Yellow', 'Soft', 'None Seen', 'None Seen', 'None Seen', 'None Seen', 'None Seen', 'None Seen', null, 'August 01, 2016');

-- ----------------------------
-- Table structure for `tbl_femaleward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_femaleward`;
CREATE TABLE `tbl_femaleward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `admissionno` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateaddmitted` varchar(255) default NULL,
  `timeaddmitted` varchar(255) default NULL,
  `admittingofficer` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_femaleward
-- ----------------------------
INSERT INTO `tbl_femaleward` VALUES ('6', 'ADM - 8', '9172016 - 3', 'Decastro ', 'Lara ', 'Urbina', '17', 'Female', '090 952-13367', 'Esla dahodine', '2016-09-20', '01:11:18 AM', 'A', '1', '');

-- ----------------------------
-- Table structure for `tbl_hematology`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_hematology`;
CREATE TABLE `tbl_hematology` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `service` varchar(255) default NULL,
  `hematologyid` varchar(255) default NULL,
  `hemoglobin` varchar(255) default NULL,
  `hematocrit` varchar(255) default NULL,
  `rbccount` varchar(255) default NULL,
  `wbccount` varchar(255) default NULL,
  `plateletcount` varchar(255) default NULL,
  `differentialcount` varchar(255) default NULL,
  `neutrophils` varchar(255) default NULL,
  `lymphocytes` varchar(255) default NULL,
  `monocytes` varchar(255) default NULL,
  `eosinophils` varchar(255) default NULL,
  `basophils` varchar(255) default NULL,
  `stabs` varchar(255) default NULL,
  `others` varchar(255) default NULL,
  `othertest` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_hematology
-- ----------------------------
INSERT INTO `tbl_hematology` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'Out - Patient', 'H - 1', '120', '0.37', '5', '5', '350', 'NA', '70', '40', '0', '5', '0', '0', 'NA', 'NA', 'July 30, 2016');
INSERT INTO `tbl_hematology` VALUES ('10', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'Out - Patient', 'H - 2', '120', '0.37', '4.55', '6', '150', 'Normal', '50', '20', '7', '5', '1', '5', 'None', '', 'September 17, 2016');
INSERT INTO `tbl_hematology` VALUES ('11', '9172016 - 3', 'De leon', 'Chadwick', 'Urbina', '17', 'Male', 'Dr. Menes', 'Out - Patient', 'H - 2', '120', '0.37', '4', '5', '150', 'Normal', '50', '20', '5', '2', '1', '5', 'None', '', 'September 17, 2016');

-- ----------------------------
-- Table structure for `tbl_isolationroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_isolationroom`;
CREATE TABLE `tbl_isolationroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `isolationroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_isolationroom
-- ----------------------------
INSERT INTO `tbl_isolationroom` VALUES ('1', 'ISW - 1', '1', 'Available');
INSERT INTO `tbl_isolationroom` VALUES ('2', 'ISW - 2', '2', 'Available');

-- ----------------------------
-- Table structure for `tbl_isolationward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_isolationward`;
CREATE TABLE `tbl_isolationward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `admissionno` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateaddmitted` varchar(255) default NULL,
  `timeaddmitted` varchar(255) default NULL,
  `admittingofficer` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_isolationward
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_laboratorypendingcheckup`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_laboratorypendingcheckup`;
CREATE TABLE `tbl_laboratorypendingcheckup` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `hematology` varchar(255) default NULL,
  `urinalysis` varchar(255) default NULL,
  `fecalysis` varchar(255) default NULL,
  `bloodbanking` varchar(255) default NULL,
  `clinicalchem` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_laboratorypendingcheckup
-- ----------------------------
INSERT INTO `tbl_laboratorypendingcheckup` VALUES ('4', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '21', 'Male', 'No', 'Yes', 'No', 'No', 'No', 'Dr. Cruz');

-- ----------------------------
-- Table structure for `tbl_maleward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_maleward`;
CREATE TABLE `tbl_maleward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `admissionno` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateaddmitted` varchar(255) default NULL,
  `timeaddmitted` varchar(255) default NULL,
  `admittingofficer` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_maleward
-- ----------------------------
INSERT INTO `tbl_maleward` VALUES ('5', 'ADM - 7', '9172016 - 4', 'Decastro ', 'Lara ', 'Urbina', '17', 'Female', '090 952-13367', 'Esla dahodine', '2016-09-20', '01:11:18 AM', 'A', '1', null);

-- ----------------------------
-- Table structure for `tbl_medicalfemalewardroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_medicalfemalewardroom`;
CREATE TABLE `tbl_medicalfemalewardroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `medicalfemaleroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_medicalfemalewardroom
-- ----------------------------
INSERT INTO `tbl_medicalfemalewardroom` VALUES ('1', 'MFW - 1', '1', 'Available');
INSERT INTO `tbl_medicalfemalewardroom` VALUES ('2', 'MFW - 2', '2', 'Available');
INSERT INTO `tbl_medicalfemalewardroom` VALUES ('3', 'MFW - 3', '3', 'Available');
INSERT INTO `tbl_medicalfemalewardroom` VALUES ('4', 'MFW - 4', '4', 'Available');
INSERT INTO `tbl_medicalfemalewardroom` VALUES ('5', 'MFW - 5', '5', 'Available');
INSERT INTO `tbl_medicalfemalewardroom` VALUES ('6', 'MFW - 6', '6', 'Available');

-- ----------------------------
-- Table structure for `tbl_medicalmalewardroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_medicalmalewardroom`;
CREATE TABLE `tbl_medicalmalewardroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `medicalmaleroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_medicalmalewardroom
-- ----------------------------
INSERT INTO `tbl_medicalmalewardroom` VALUES ('1', 'MMW - 1', '1', 'Taken');
INSERT INTO `tbl_medicalmalewardroom` VALUES ('2', 'MMW - 2', '2', 'Available');
INSERT INTO `tbl_medicalmalewardroom` VALUES ('3', 'MMW - 3', '3', 'Available');
INSERT INTO `tbl_medicalmalewardroom` VALUES ('4', 'MMW - 4', '4', 'Available');
INSERT INTO `tbl_medicalmalewardroom` VALUES ('5', 'MMW - 5', '5', 'Available');

-- ----------------------------
-- Table structure for `tbl_medicalrecord`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_medicalrecord`;
CREATE TABLE `tbl_medicalrecord` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateadmitted` varchar(255) default NULL,
  `timeadmitted` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `observation` varchar(255) default NULL,
  `dateofobservation` varchar(255) default NULL,
  `timeofobservation` varchar(255) default NULL,
  `wardtype` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_medicalrecord
-- ----------------------------
INSERT INTO `tbl_medicalrecord` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', '090 952-13367', '173 Aida St. Marick Sub Cainta Rizal', '2016-09-17', '12:03:35 PM', '1', 'Getting  better.', '2016-09-17', '12:09:48 PM', 'Medical Male Ward');

-- ----------------------------
-- Table structure for `tbl_obgyneroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_obgyneroom`;
CREATE TABLE `tbl_obgyneroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `obgyneroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_obgyneroom
-- ----------------------------
INSERT INTO `tbl_obgyneroom` VALUES ('1', 'OBW - 1', '1', 'Available');
INSERT INTO `tbl_obgyneroom` VALUES ('2', 'OBW - 2', '2', 'Available');
INSERT INTO `tbl_obgyneroom` VALUES ('3', 'OBW - 3', '3', 'Available');
INSERT INTO `tbl_obgyneroom` VALUES ('4', 'OBW - 4', '4', 'Available');
INSERT INTO `tbl_obgyneroom` VALUES ('5', 'OBW - 5', '5', 'Available');

-- ----------------------------
-- Table structure for `tbl_obgyneward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_obgyneward`;
CREATE TABLE `tbl_obgyneward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `admissionno` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateaddmitted` varchar(255) default NULL,
  `timeaddmitted` varchar(255) default NULL,
  `admittingofficer` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_obgyneward
-- ----------------------------
INSERT INTO `tbl_obgyneward` VALUES ('6', 'ADM - 8', '9172016 - 3', 'Decastro ', 'Lara ', 'Urbina', '17', 'Female', '090 952-13367', 'Esla dahodine', '2016-09-20', '01:11:18 AM', 'A', '1', '');

-- ----------------------------
-- Table structure for `tbl_pediatricroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pediatricroom`;
CREATE TABLE `tbl_pediatricroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `pediatricroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_pediatricroom
-- ----------------------------
INSERT INTO `tbl_pediatricroom` VALUES ('1', 'PTW - 1', '1', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('2', 'PTW - 2', '2', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('3', 'PTW - 3', '3', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('4', 'PTW - 4', '4', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('5', 'PTW - 5', '5', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('6', 'PTW - 6', '6', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('7', 'PTW - 7', '7', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('8', 'PTW - 8', '8', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('9', 'PTW - 9', '9', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('10', 'PTW - 10', '10', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('11', 'PTW - 11', '11', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('12', 'PTW - 12', '12', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('13', 'PTW - 13', '13', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('14', 'PTW - 14', '14', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('15', 'PTW - 15', '15', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('16', 'PTW - 16', '16', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('17', 'PTW - 17', '17', 'Available');
INSERT INTO `tbl_pediatricroom` VALUES ('18', 'PTW - 18', '18', 'Available');

-- ----------------------------
-- Table structure for `tbl_pediatricward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pediatricward`;
CREATE TABLE `tbl_pediatricward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `admissionno` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateaddmitted` varchar(255) default NULL,
  `timeaddmitted` varchar(255) default NULL,
  `admittingofficer` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_pediatricward
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_pendingbill_ancillary`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pendingbill_ancillary`;
CREATE TABLE `tbl_pendingbill_ancillary` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `xray` varchar(255) default NULL,
  `ecg` varchar(255) default NULL,
  `ctscan` varchar(255) default NULL,
  `hematology` varchar(255) default NULL,
  `urinalysis` varchar(255) default NULL,
  `fecalysis` varchar(255) default NULL,
  `bloodbanking` varchar(255) default NULL,
  `clinicalchem` varchar(255) default NULL,
  `otherfee` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `status` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_pendingbill_ancillary
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_phildiscount`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_phildiscount`;
CREATE TABLE `tbl_phildiscount` (
  `philcount` int(11) NOT NULL auto_increment,
  `diagnosis` varchar(255) default NULL,
  `icd` varchar(255) default NULL,
  `caserate` varchar(255) default NULL,
  `pf` varchar(255) default NULL,
  `hospital` varchar(255) default NULL,
  `status` varchar(255) default NULL,
  PRIMARY KEY  (`philcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_phildiscount
-- ----------------------------
INSERT INTO `tbl_phildiscount` VALUES ('1', 'D & C', '58120', '11000', '4400', '6600', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('2', 'ACUTE APPENDICTIS(APPENDECTOMY)', '44950', '24,000.00', '9,600.00', '14,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('3', 'ACUTE RESPIRATORY FAILURE', 'J96.0', '32,000.00', '9,600.00', '22,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('4', 'AGE(with fecalysis)', 'A09.9', '6,000.00', '1,800.00', '4,200.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('5', 'AMI', 'I21.9', '18,900.00', '5,670.00', '13,230.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('6', 'BAIAE', 'J45.90', '9,000.00', '2,700.00', '6,300.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('7', 'BFC', 'R56.0', '7,000.00', '2,100.00', '4,900.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('8', 'BPN.MOD.RISK', 'J18.92', '15,000.00', '4,500.00', '10,500.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('9', 'C/S', '59513', '19,000.00', '7,600.00', '11,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('10', 'COPD', 'J44.9', '12,200.00', '3,660.00', '8,540.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('11', 'DFS', 'A90', '10,000.00', '3,000.00', '7,000.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('12', 'DM TYPE 2(with multiple complication)', 'E11.7', '12,600.00', '3,780.00', '8,820.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('13', 'ELECTROLYTES IMNBALANCE', 'E87.8', '8,500.00', '2,550.00', '5,950.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('14', 'FISTULA IN ANO', '46060', '9,700.00', '4,200.00', '5,500.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('15', 'HCVD', 'I11.9', '9,000.00', '2,700.00', '6,300.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('16', 'HPN', 'I10.9', '9,000.00', '2,700.00', '6,300.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('17', 'HPN II', 'I10.1', '9,000.00', '2,700.00', '6,300.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('18', 'HPP', 'G72.3', '7,900.00', '2,370.00', '5,530.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('19', 'INCOMPLETE ABORTION(NO ASC)', '59812', '11,000.00', '4,400.00', '6,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('20', 'MRM', '19200', '22,000.00', '8,800.00', '13,200.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('21', 'NSD(with check-up 4 times)', '59400', '9,700.00', '4,200.00', '5,500.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('22', 'PCAP/CAP MR', 'J18.92', '15,000.00', '4,500.00', '10,500.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('23', 'PNA MEASLES', 'B05.2,J17.1', '15,000.00', '4,500.00', '10,500.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('24', 'PNA RUBELLA', 'B06.8,J17.1', '15,000.00', '4,500.00', '10,500.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('25', 'PTB III', 'A16.2', '9,800.00', '2,940.00', '6,860.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('26', 'UTI(with urinalysis)', 'N39.0', '7,500.00', '2,250.00', '5,250.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('27', 'AGN', 'N000', '10,000.00', '3,000.00', '7,000.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('28', 'CVA RADIATA', 'I63.9', '28,000.00', '8,400.00', '19,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('29', 'CELLULITIS LEG', 'L03.1', '9,600.00', '2,880.00', '6,720.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('30', 'CVA INTERNAL CAPSULE', 'I63.8', '28,000.00', '8,400.00', '19,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('31', 'ANEMIA', 'D64.9', '10,000.00', '3,000.00', '7,000.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('32', 'CHOLECYSTITIS(OPEN CHOLECYSTECTOMY)', '47600', '31,000.00', '12,400.00', '18,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('33', 'SEPSIS NEONATRUM', 'P36.9', '11,700.00', '3,510.00', '8,190.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('34', 'HYPERTENSIVE SCHEMIC HEART DESEASE', 'I25.9', '12,000.00', '3,600.00', '8,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('35', 'NEONATAL SEPSIS', 'P36.9', '11,700.00', '3,510.00', '8,190.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('36', 'DM FOOT RIGHT(exasion debridement)', 'E14.5,11012', '12,120.00', '6,720.00', '5,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('37', 'ACUTE GASTRITIS', 'K29.1', '6,100.00', '1,830.00', '4,870.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('38', 'HERNIORRAPHY', '49520', '21,000.00', '8,400.00', '12,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('39', 'DEBRIDEMENT(BONE & MUSCLE)', '11012', '12,120.00', '6,720.00', '5,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('40', 'DEBRIDEMENT(SKIN & MUSCLE)', '11011', '11,980.00', '5,880.00', '6,100.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('41', 'CARDIAC ARRYTHMIA', 'I49.9', '12,200.00', '3,660.00', '8,540.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('42', 'DHF 1', 'A91.1', '10,000.00', '3,000.00', '7,000.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('43', 'TRANSIENT ISCHEMIC ATTAKCS', '6.45.8', '7,300.00', '2,190.00', '5,110.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('44', 'DIABETIC FOOT', 'E14.5', '12,600.00', '3,780.00', '8,820.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('45', 'CAPRAL TUNNEL SYNDROME', '656.0/25020', '18,000.00', '8,400.00', '9,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('46', 'ACS', 'I20.0', '12,000.00', '3,600.00', '8,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('47', 'ACUTE PYELONEPHRITIS', 'N10', '10,000.00', '3,000.00', '7,000.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('48', 'VALVULAR HEART DISEASE', 'I38', '14,400.00', '4,320.00', '10,080.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('49', 'HYPOCALEMIC PERIODIC PARALYSIS', '672.3', '7,900.00', '2,370.00', '5,530.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('50', 'NEONATAL PNEUMONIA', 'P23.9', '12,700.00', '3,810.00', '8,890.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('51', 'CHRONIC KIDNEY DESEASE', 'N.19', '14,500.00', '3,450.00', '10,150.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('52', 'SEPTIC SHOCK/SEPSIS', 'A41.9', '32,000.00', '9,600.00', '22,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('53', 'ACUTE RENAL FAILURE', 'N17.9', '19,300.00', '5,790.00', '13,510.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('54', 'THYROTOXICOSIS', 'EO5.9', '8,500.00', '2,550.00', '5,950.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('55', 'UNSTABLE ANGINA', 'I20.0', '12,000.00', '3,600.00', '8,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('56', 'CHEMO THERAPY', '96408', '7,280.00', '1,680.00', '5,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('57', 'TOTAL THYROIDECTOMY(with isthmusectomy)', '60225', '31,000.00', '12,400.00', '18,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('58', 'ALCOHOLIC LIVER CIRRHOSIS', 'K70.3', '11,800.00', '3,540.00', '8,260.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('59', 'SEPSIS', 'A41.9', '32,000.00', '9,600.00', '22,400.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('60', 'TONSILLECTOMY', '42825', '15,000.00', '8,4000.00', '9,600.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('61', 'ABSCESS', '102.9', '4,000.00', '1,200.00', '2,800.00', 'Enable');
INSERT INTO `tbl_phildiscount` VALUES ('62', 'UROSEPSIS', 'N39.0', '5,250.00', '2,250.00', '7,500.00', 'Enable');

-- ----------------------------
-- Table structure for `tbl_qnumbers`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_qnumbers`;
CREATE TABLE `tbl_qnumbers` (
  `qnumberlab` varchar(255) default NULL,
  `qnumberxray` varchar(255) default NULL,
  `qnumberctscan` varchar(255) default NULL,
  `qnumberecg` varchar(255) default NULL,
  `qlabvalue` varchar(255) default NULL,
  `qxrayvalue` varchar(255) default NULL,
  `qctscanvalue` varchar(255) default NULL,
  `qecgvalue` varchar(255) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_qnumbers
-- ----------------------------
INSERT INTO `tbl_qnumbers` VALUES ('50', '60', '60', '60', '8', '5', '5', '5');

-- ----------------------------
-- Table structure for `tbl_roomprice`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_roomprice`;
CREATE TABLE `tbl_roomprice` (
  `roomprice` int(11) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_roomprice
-- ----------------------------
INSERT INTO `tbl_roomprice` VALUES ('50');

-- ----------------------------
-- Table structure for `tbl_surgicalroom`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_surgicalroom`;
CREATE TABLE `tbl_surgicalroom` (
  `roomcount` int(11) NOT NULL auto_increment,
  `roomid` varchar(255) default NULL,
  `surgicalroomcount` varchar(255) default NULL,
  `roomstatus` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_surgicalroom
-- ----------------------------
INSERT INTO `tbl_surgicalroom` VALUES ('1', 'SLW - 1', '1', 'Available');
INSERT INTO `tbl_surgicalroom` VALUES ('2', 'SLW - 2', '2', 'Available');
INSERT INTO `tbl_surgicalroom` VALUES ('3', 'SLW - 3', '3', 'Available');
INSERT INTO `tbl_surgicalroom` VALUES ('4', 'SLW - 4', '4', 'Available');
INSERT INTO `tbl_surgicalroom` VALUES ('5', 'SLW - 5', '5', 'Available');
INSERT INTO `tbl_surgicalroom` VALUES ('6', 'SLW - 6', '6', 'Available');

-- ----------------------------
-- Table structure for `tbl_surgicalward`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_surgicalward`;
CREATE TABLE `tbl_surgicalward` (
  `roomcount` int(11) NOT NULL auto_increment,
  `admissionno` varchar(255) default NULL,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `contact` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  `dateaddmitted` varchar(255) default NULL,
  `timeaddmitted` varchar(255) default NULL,
  `admittingofficer` varchar(255) default NULL,
  `bednumber` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`roomcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_surgicalward
-- ----------------------------
INSERT INTO `tbl_surgicalward` VALUES ('6', 'ADM - 8', '9172016 - 3', 'Decastro ', 'Lara ', 'Urbina', '17', 'Female', '090 952-13367', 'Esla dahodine', '2016-09-20', '01:11:18 AM', 'A', '1', '');

-- ----------------------------
-- Table structure for `tbl_urinalysis`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_urinalysis`;
CREATE TABLE `tbl_urinalysis` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  `roomcompany` varchar(255) default NULL,
  `urinalysisid` varchar(255) default NULL,
  `color` varchar(255) default NULL,
  `transparency` varchar(255) default NULL,
  `ph` varchar(255) default NULL,
  `specificgravity` varchar(255) default NULL,
  `sugar` varchar(255) default NULL,
  `protein` varchar(255) default NULL,
  `redbloodcells` varchar(255) default NULL,
  `puscells` varchar(255) default NULL,
  `bacteria` varchar(255) default NULL,
  `epithelialcells` varchar(255) default NULL,
  `mucusthreads` varchar(255) default NULL,
  `cast` varchar(255) default NULL,
  `crystals` varchar(255) default NULL,
  `amorphousmaterials` varchar(255) default NULL,
  `othertest` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_urinalysis
-- ----------------------------
INSERT INTO `tbl_urinalysis` VALUES ('1', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Dr. Menes', 'Out - Patient', 'CM - 1', 'Yellow', 'Clear', '5.0', '1.005', 'Negative', 'Negative', '3', '5', 'None', 'Few', 'None', 'None', 'NA', 'NA', 'NA', 'July 31, 2016');
INSERT INTO `tbl_urinalysis` VALUES ('8', '9172016 - 4', 'Decastro', 'Lara', 'Urbina', '17', 'Female', 'Dr. Menes', 'Out - Patient', 'CM - 2', 'Yellow', 'Clear', '6.1', '1.009', 'Negative', 'Negative', '2', '3', 'None', 'None', 'Few', 'None', 'normal', 'normal', 'none', 'September 17, 2016');

-- ----------------------------
-- Table structure for `tbl_usercontrol`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_usercontrol`;
CREATE TABLE `tbl_usercontrol` (
  `usercount` int(11) NOT NULL auto_increment,
  `userid` varchar(255) default NULL,
  `register` varchar(255) default NULL,
  `doctor` varchar(255) default NULL,
  `viewpatient` varchar(255) default NULL,
  `ancillary` varchar(255) default NULL,
  `result` varchar(255) default NULL,
  `billing` varchar(255) default NULL,
  `reports` varchar(255) default NULL,
  `emergency` varchar(255) default NULL,
  `admitting` varchar(255) default NULL,
  `ward` varchar(255) default NULL,
  PRIMARY KEY  (`usercount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_usercontrol
-- ----------------------------
INSERT INTO `tbl_usercontrol` VALUES ('1', 'NUR - 25', 'Access', 'Denied', 'Denied', 'Access', 'Access', 'Access', 'Denied', 'Denied', 'Denied', 'Denied');

-- ----------------------------
-- Table structure for `tbl_wardrequestcheckup`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_wardrequestcheckup`;
CREATE TABLE `tbl_wardrequestcheckup` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `hematology` varchar(255) default NULL,
  `urinalysis` varchar(255) default NULL,
  `fecalysis` varchar(255) default NULL,
  `bloodbanking` varchar(255) default NULL,
  `clinicalchem` varchar(255) default NULL,
  `ecg` varchar(255) default NULL,
  `ctscan` varchar(255) default NULL,
  `xray` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_wardrequestcheckup
-- ----------------------------
INSERT INTO `tbl_wardrequestcheckup` VALUES ('10', '9172016 - 3', '0', '0', '0', '0', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `tbl_xraypendingcheckup`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_xraypendingcheckup`;
CREATE TABLE `tbl_xraypendingcheckup` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `physician` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_xraypendingcheckup
-- ----------------------------
INSERT INTO `tbl_xraypendingcheckup` VALUES ('1', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '21', 'Male', 'Dr. Cruz');
INSERT INTO `tbl_xraypendingcheckup` VALUES ('2', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '56', 'Male', 'Dr. Perez');

-- ----------------------------
-- Table structure for `tbl_xrayresult`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_xrayresult`;
CREATE TABLE `tbl_xrayresult` (
  `patientcount` int(11) NOT NULL auto_increment,
  `hospitalnumber` varchar(255) default NULL,
  `surname` varchar(255) default NULL,
  `firstname` varchar(255) default NULL,
  `middlename` varchar(255) default NULL,
  `age` varchar(255) default NULL,
  `sex` varchar(255) default NULL,
  `xrayresult` text,
  `physician` varchar(255) default NULL,
  `time` varchar(255) default NULL,
  `date` varchar(255) default NULL,
  PRIMARY KEY  (`patientcount`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_xrayresult
-- ----------------------------
INSERT INTO `tbl_xrayresult` VALUES ('4', '9172016 - 1', 'Santos', 'Arwin', 'Cruz', '20', 'Male', 'Damage!', 'Dr. Menes', '06:16:28 PM', 'September 15, 2016');
INSERT INTO `tbl_xrayresult` VALUES ('8', '9172016 - 5', 'Menes ', 'Daniel Anthony ', 'Dela Cruz', '21', 'Male', 'missing one lung', 'Dr. Cruz', '07:17:46 PM', 'September 17, 2016');
INSERT INTO `tbl_xrayresult` VALUES ('9', '9202016 - 6', 'Dino ', 'Norman ', 'Avelaneda', '56', 'Male', '3 lungs', 'Dr. Perez', '07:54:28 PM', 'September 20, 2016');
