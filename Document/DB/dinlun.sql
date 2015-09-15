/*
SQLyog Ultimate v11.24 (32 bit)
MySQL - 5.6.25 : Database - dinlun
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `newsmsg` */

DROP TABLE IF EXISTS `newsmsg`;

CREATE TABLE `newsmsg` (
  `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT '主键',
  `Title` varchar(255) NOT NULL COMMENT '新闻标题',
  `Content` text NOT NULL COMMENT '新闻内容',
  `NewsType` int(11) NOT NULL COMMENT '企业动态 1 行业新闻 2 媒体新闻 3',
  `ImgUrl` varchar(255) DEFAULT NULL COMMENT '图片地址',
  `InsertTime` datetime NOT NULL COMMENT '生成时间',
  `avg1` varchar(5) DEFAULT NULL COMMENT '扩展字段1',
  `avg2` varchar(5) DEFAULT NULL COMMENT '扩展字段2',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
