CREATE TABLE IF NOT EXISTS `books` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `author` varchar(80) NOT NULL,
  `launch_date` DateTime NOT NULL,
  `price` decimal(18, 2) NOT NULL,
  `title` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) 