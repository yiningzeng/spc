/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 50728
 Source Host           : localhost:3306
 Source Schema         : spc

 Target Server Type    : MySQL
 Target Server Version : 50728
 File Encoding         : 65001

 Date: 06/09/2020 23:04:26
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for aoi_ng_types
-- ----------------------------
DROP TABLE IF EXISTS `aoi_ng_types`;
CREATE TABLE `aoi_ng_types`  (
  `id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ng_str` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `software_id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `create_time` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `ng_types_ibfk_1`(`software_id`) USING BTREE,
  CONSTRAINT `aoi_ng_types_ibfk_1` FOREIGN KEY (`software_id`) REFERENCES `aoi_softwares` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of aoi_ng_types
-- ----------------------------
INSERT INTO `aoi_ng_types` VALUES ('1', '12', '1', '2020-09-05 18:22:30');
INSERT INTO `aoi_ng_types` VALUES ('2', '33', '1', '2020-09-05 18:22:48');

-- ----------------------------
-- Table structure for aoi_pcbs
-- ----------------------------
DROP TABLE IF EXISTS `aoi_pcbs`;
CREATE TABLE `aoi_pcbs`  (
  `id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `software_id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `pcb_number` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `pcb_name` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT '',
  `carrier_width` int(11) NULL DEFAULT NULL,
  `carrier_height` int(11) NULL DEFAULT NULL,
  `pcb_width` int(11) NOT NULL,
  `pcb_height` int(11) NOT NULL,
  `pcb_childen_number` int(11) NOT NULL,
  `pcb_path` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `ng_count` int(11) NULL DEFAULT NULL,
  `is_misjudge` int(11) NOT NULL,
  `is_error` int(11) NOT NULL,
  `create_time` datetime(0) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `software_id`(`software_id`) USING BTREE,
  CONSTRAINT `aoi_pcbs_ibfk_1` FOREIGN KEY (`software_id`) REFERENCES `aoi_softwares` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of aoi_pcbs
-- ----------------------------
INSERT INTO `aoi_pcbs` VALUES ('25969228997592064', '1', 'code23123', '213123', 220, 90, 190, 50, 2, '2020-07-29\\26123568049554432', 12, 0, 1, '2020-09-06 18:02:53');
INSERT INTO `aoi_pcbs` VALUES ('25969228997592065', '1', 'code2', '213123', 220, 90, 190, 50, 2, '2020-07-29\\26123568049554432', 32, 0, 1, '2020-09-06 18:02:57');

-- ----------------------------
-- Table structure for aoi_pcs
-- ----------------------------
DROP TABLE IF EXISTS `aoi_pcs`;
CREATE TABLE `aoi_pcs`  (
  `id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `pc_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `pc_ip` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `create_time` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of aoi_pcs
-- ----------------------------
INSERT INTO `aoi_pcs` VALUES ('1', '23', '127.0.0.1', '2020-09-06 11:48:48');
INSERT INTO `aoi_pcs` VALUES ('12222', '1', '127.0.0.1', '2020-09-02 18:00:53');

-- ----------------------------
-- Table structure for aoi_results
-- ----------------------------
DROP TABLE IF EXISTS `aoi_results`;
CREATE TABLE `aoi_results`  (
  `id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `is_back` int(11) NOT NULL,
  `score` float(11, 11) NULL DEFAULT NULL,
  `pcb_id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `area` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `region` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `ng_type_id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `is_misjudge` int(11) NOT NULL,
  `result_string` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `part_image_path` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `create_time` datetime(0) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `IX_pcb_id`(`pcb_id`) USING BTREE,
  INDEX `ng_type_id`(`ng_type_id`) USING BTREE,
  CONSTRAINT `FK_results_pcbs_pcb_id` FOREIGN KEY (`pcb_id`) REFERENCES `aoi_pcbs` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `aoi_results_ibfk_1` FOREIGN KEY (`ng_type_id`) REFERENCES `aoi_ng_types` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of aoi_results
-- ----------------------------
INSERT INTO `aoi_results` VALUES ('1', 1, 0.87000000477, '25969228997592064', '12,23,41,11', '12,23,41,11', '1', 1, '', '\\results\\26123568108440576.jpg', '2020-09-05 21:57:33');

-- ----------------------------
-- Table structure for aoi_softwares
-- ----------------------------
DROP TABLE IF EXISTS `aoi_softwares`;
CREATE TABLE `aoi_softwares`  (
  `id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `software_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `pc_id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `side_number` int(11) NULL DEFAULT NULL COMMENT '1 单面 2 双面',
  `create_time` datetime(0) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `pc_id`(`pc_id`) USING BTREE,
  CONSTRAINT `aoi_softwares_ibfk_1` FOREIGN KEY (`pc_id`) REFERENCES `aoi_pcs` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of aoi_softwares
-- ----------------------------
INSERT INTO `aoi_softwares` VALUES ('1', '双面', '1', 2, '2020-09-05 18:21:29');
INSERT INTO `aoi_softwares` VALUES ('2', 'ceshi1', '1', 1, '2020-09-05 18:21:12');

-- ----------------------------
-- Table structure for aoi_user_groups
-- ----------------------------
DROP TABLE IF EXISTS `aoi_user_groups`;
CREATE TABLE `aoi_user_groups`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `group_name` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `type` int(11) NOT NULL,
  `create_time` datetime(0) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of aoi_user_groups
-- ----------------------------
INSERT INTO `aoi_user_groups` VALUES (1, '管理员', 1, '2019-12-20 18:05:00');

-- ----------------------------
-- Table structure for aoi_users
-- ----------------------------
DROP TABLE IF EXISTS `aoi_users`;
CREATE TABLE `aoi_users`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `password` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `type` int(11) NOT NULL,
  `create_time` datetime(0) NOT NULL,
  `group_id` int(11) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of aoi_users
-- ----------------------------
INSERT INTO `aoi_users` VALUES (1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 1, '2019-12-09 17:15:11', 1);

SET FOREIGN_KEY_CHECKS = 1;
