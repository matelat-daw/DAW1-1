-- phpMyAdmin SQL Dump
-- version 2.10.2
-- http://www.phpmyadmin.net
-- 
-- Servidor: localhost
-- Tiempo de generación: 19-11-2010 a las 13:26:09
-- Versión del servidor: 5.0.45
-- Versión de PHP: 5.2.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- 
-- Base de datos: `practica1`
-- 
CREATE DATABASE `practica1` DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci;
USE `practica1`;

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `centros`
-- 

CREATE TABLE `centros` (
  `numero` int(10) NOT NULL,
  `nombre` text collate utf8_spanish_ci NOT NULL,
  `direccion` text collate utf8_spanish_ci NOT NULL,
  PRIMARY KEY  (`numero`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Volcar la base de datos para la tabla `centros`
-- 

INSERT INTO `centros` VALUES (10, 'SEDE CENTRAL', 'C/ALCALA 820, MADRID');
INSERT INTO `centros` VALUES (20, 'RELACIONES CON CLIENTES', 'C/ATOCHA 405, MADRID');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `departamentos`
-- 

CREATE TABLE `departamentos` (
  `numero` int(5) NOT NULL,
  `centro` int(5) NOT NULL,
  `director` int(50) NOT NULL,
  `tipo_dir` text collate utf8_spanish_ci NOT NULL,
  `presupuesto` int(5) NOT NULL,
  `depto_jefe` int(5) default NULL,
  `nombre` text collate utf8_spanish_ci NOT NULL,
  PRIMARY KEY  (`numero`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Volcar la base de datos para la tabla `departamentos`
-- 

INSERT INTO `departamentos` VALUES (100, 10, 260, 'P', 12, 0, 'DIRECCION GENERAL');
INSERT INTO `departamentos` VALUES (110, 20, 180, 'P', 15, 100, 'DIRECCION COMERCIAL');
INSERT INTO `departamentos` VALUES (111, 20, 180, 'F', 11, 110, 'SECTOR INDUSTRIAL');
INSERT INTO `departamentos` VALUES (112, 20, 270, 'P', 9, 100, 'SECTOR DE SERVICIOS');
INSERT INTO `departamentos` VALUES (122, 10, 350, 'P', 6, 120, 'PROCESO DE DATOS');
INSERT INTO `departamentos` VALUES (120, 10, 150, 'F', 3, 100, 'ORGANIZACION');
INSERT INTO `departamentos` VALUES (121, 10, 150, 'P', 2, 120, 'PERSONAL');
INSERT INTO `departamentos` VALUES (130, 10, 310, 'P', 2, 100, 'FINANZAS');

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `empleados`
-- 

CREATE TABLE `empleados` (
  `cod` int(5) NOT NULL,
  `departamento` int(5) NOT NULL,
  `telefono` int(5) NOT NULL,
  `fechaNac` date NOT NULL,
  `fecha` date NOT NULL,
  `salario` int(10) NOT NULL,
  `comision` int(5) default NULL,
  `numhijos` int(5) NOT NULL,
  `nombre` text collate utf8_spanish_ci NOT NULL,
  PRIMARY KEY  (`cod`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Volcar la base de datos para la tabla `empleados`
-- 

INSERT INTO `empleados` VALUES (110, 121, 350, '1935-11-10', '1950-02-10', 1310, 0, 3, 'PONS, CESAR');
INSERT INTO `empleados` VALUES (120, 112, 840, '1945-06-09', '1968-10-01', 1350, 110, 1, 'LASA, MARIO');
INSERT INTO `empleados` VALUES (130, 112, 810, '1955-11-09', '1969-02-01', 1290, 110, 2, 'TEROL, LUCIANO');
INSERT INTO `empleados` VALUES (150, 121, 340, '1940-08-10', '1948-01-15', 1440, 0, 0, 'PEREZ, JULIO');
INSERT INTO `empleados` VALUES (160, 111, 740, '1949-07-09', '1968-11-11', 1310, 110, 2, 'AGUIRRE, AUREO');
INSERT INTO `empleados` VALUES (180, 110, 508, '1944-10-18', '1956-03-18', 1480, 50, 2, 'PEREZ, MARCOS');
INSERT INTO `empleados` VALUES (190, 121, 350, '1942-05-12', '1962-02-11', 1300, 0, 4, 'VEIGA, JULIANA');
INSERT INTO `empleados` VALUES (210, 100, 200, '1950-09-28', '1959-01-22', 1380, 0, 2, 'GALVEZ, PILAR');
INSERT INTO `empleados` VALUES (240, 111, 760, '1952-02-26', '1966-02-24', 1280, 100, 3, 'SANZ, LAVINIA');
INSERT INTO `empleados` VALUES (250, 100, 250, '1965-10-27', '1967-03-01', 1450, 0, 0, 'ALBA, ADRIANA');