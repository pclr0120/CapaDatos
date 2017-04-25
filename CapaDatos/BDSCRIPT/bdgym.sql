-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: bdgym
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `asistencias`
--

DROP TABLE IF EXISTS `asistencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencias` (
  `IdCliente` int(11) NOT NULL AUTO_INCREMENT,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdCliente`),
  CONSTRAINT `asistencias_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `empleado` (`IdEmpleado`),
  CONSTRAINT `asistencias_ibfk_2` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencias`
--

LOCK TABLES `asistencias` WRITE;
/*!40000 ALTER TABLE `asistencias` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudad` (
  `IdCiudad` int(11) NOT NULL AUTO_INCREMENT,
  `IdMunicipio` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `FecharRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdCiudad`),
  KEY `IdMunicipio` (`IdMunicipio`),
  CONSTRAINT `ciudad_ibfk_1` FOREIGN KEY (`IdMunicipio`) REFERENCES `municipio` (`IdMunicipio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `IdCliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `App` varchar(30) NOT NULL,
  `Apm` varchar(30) NOT NULL,
  `Foto` varchar(100) DEFAULT NULL,
  `FechaNacimiento` datetime DEFAULT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `CodigoPersonal` varchar(5) DEFAULT NULL,
  `CodigoInvitacion` varchar(5) DEFAULT NULL,
  `Domicilio` varchar(30) DEFAULT NULL,
  `Telefono` varchar(10) DEFAULT NULL,
  `IdTipoMembrecia` int(11) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdCliente`),
  KEY `IdTipoMembrecia` (`IdTipoMembrecia`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`IdTipoMembrecia`) REFERENCES `tipomembrecia` (`IdTipoMembrecia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallepromo`
--

DROP TABLE IF EXISTS `detallepromo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallepromo` (
  `IdDetallePromo` int(11) NOT NULL AUTO_INCREMENT,
  `IdProducto` int(11) NOT NULL,
  `Precio` double DEFAULT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdDetallePromo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallepromo`
--

LOCK TABLES `detallepromo` WRITE;
/*!40000 ALTER TABLE `detallepromo` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallepromo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleventa` (
  `IdDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `IdProducto` int(11) NOT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `PrecioProducto` double DEFAULT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdDetalle`),
  KEY `IdProducto` (`IdProducto`),
  CONSTRAINT `detalleventa_ibfk_1` FOREIGN KEY (`IdProducto`) REFERENCES `producto` (`IdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `IdEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `App` varchar(30) NOT NULL,
  `Apm` varchar(30) NOT NULL,
  `IdTipoEmpleado` int(11) NOT NULL,
  `Telefono` varchar(12) NOT NULL,
  `IdCiudad` int(11) NOT NULL,
  `Domicilio` varchar(30) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdEmpleado`),
  KEY `IdCiudad` (`IdCiudad`),
  KEY `IdTipoEmpleado` (`IdTipoEmpleado`),
  CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`IdCiudad`) REFERENCES `ciudad` (`IdCiudad`),
  CONSTRAINT `empleado_ibfk_2` FOREIGN KEY (`IdTipoEmpleado`) REFERENCES `tipoempleado` (`IdTipoEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entidadf`
--

DROP TABLE IF EXISTS `entidadf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entidadf` (
  `IdEntidadF` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `FecharRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdEntidadF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entidadf`
--

LOCK TABLES `entidadf` WRITE;
/*!40000 ALTER TABLE `entidadf` DISABLE KEYS */;
/*!40000 ALTER TABLE `entidadf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipo` (
  `IdEquipo` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Codigo` varchar(20) NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `familia`
--

DROP TABLE IF EXISTS `familia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `familia` (
  `IdFamilia` int(11) NOT NULL AUTO_INCREMENT,
  `Familia` varchar(20) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdFamilia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `familia`
--

LOCK TABLES `familia` WRITE;
/*!40000 ALTER TABLE `familia` DISABLE KEYS */;
/*!40000 ALTER TABLE `familia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `infogeneral`
--

DROP TABLE IF EXISTS `infogeneral`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `infogeneral` (
  `Nombre` varchar(50) DEFAULT NULL,
  `NombreComercial` varchar(50) DEFAULT NULL,
  `Ciudad` int(11) DEFAULT NULL,
  `CodigoPostal` varchar(5) DEFAULT NULL,
  `Telefono` varchar(12) DEFAULT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `Giro` varchar(50) DEFAULT NULL,
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  KEY `infogeneral_ibfk_1` (`Ciudad`),
  CONSTRAINT `infogeneral_ibfk_1` FOREIGN KEY (`Ciudad`) REFERENCES `ciudad` (`IdCiudad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `infogeneral`
--

LOCK TABLES `infogeneral` WRITE;
/*!40000 ALTER TABLE `infogeneral` DISABLE KEYS */;
INSERT INTO `infogeneral` VALUES ('0','0',NULL,NULL,'0',NULL,NULL,'2017-03-12 22:12:01'),('0','0',NULL,NULL,'0',NULL,NULL,'2017-03-12 22:12:48'),('fd','fd',NULL,NULL,'fd',NULL,NULL,'2017-03-12 22:12:59'),('hol5','jajgfga',NULL,NULL,'123114gf',NULL,NULL,'2017-03-13 01:31:21');
/*!40000 ALTER TABLE `infogeneral` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipio`
--

DROP TABLE IF EXISTS `municipio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `municipio` (
  `IdMunicipio` int(11) NOT NULL AUTO_INCREMENT,
  `IdEntidad` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `FecharRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdMunicipio`),
  KEY `IdEntidad` (`IdEntidad`),
  CONSTRAINT `municipio_ibfk_1` FOREIGN KEY (`IdEntidad`) REFERENCES `entidadf` (`IdEntidadF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipio`
--

LOCK TABLES `municipio` WRITE;
/*!40000 ALTER TABLE `municipio` DISABLE KEYS */;
/*!40000 ALTER TABLE `municipio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `IdProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `Descripcion` varchar(50) DEFAULT NULL,
  `IdProvedor` int(11) DEFAULT NULL,
  `Codigo` varchar(10) NOT NULL,
  `Stock` int(11) NOT NULL,
  `StockMin` int(11) NOT NULL,
  `Costo` double NOT NULL,
  `Precio` double NOT NULL,
  `Promocion` varchar(1) DEFAULT NULL,
  `IdPromocion` int(11) DEFAULT NULL,
  `PrecioMinimo` double NOT NULL,
  `IdUnidadMedida` int(11) DEFAULT NULL,
  `IdFamilia` int(11) DEFAULT NULL,
  `FechaCaducidad` datetime DEFAULT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  `IVA` double DEFAULT NULL,
  PRIMARY KEY (`IdProducto`),
  KEY `IdPromocion` (`IdPromocion`),
  KEY `producto_ibfk_1` (`IdFamilia`),
  KEY `producto_ibfk_2` (`IdUnidadMedida`),
  KEY `producto_ibfk_3` (`IdProvedor`),
  CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`IdFamilia`) REFERENCES `familia` (`IdFamilia`),
  CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`IdUnidadMedida`) REFERENCES `unidadmedida` (`IdUnidadMedida`),
  CONSTRAINT `producto_ibfk_3` FOREIGN KEY (`IdProvedor`) REFERENCES `provedor` (`IdProvedor`),
  CONSTRAINT `producto_ibfk_4` FOREIGN KEY (`IdPromocion`) REFERENCES `promocion` (`IdPromocion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'lechuga','nada',NULL,'23',22,22,22,23,NULL,NULL,3,NULL,NULL,NULL,'2017-03-21 00:59:04','A',16),(2,'platano','nada',NULL,'24',22,22,21,21,NULL,NULL,3,NULL,NULL,NULL,'2017-03-21 12:21:12','A',16);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `promocion`
--

DROP TABLE IF EXISTS `promocion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `promocion` (
  `IdPromocion` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `IdDetallePromo` int(11) NOT NULL,
  `Descripcion` varchar(100) NOT NULL,
  `Codigo` varchar(10) NOT NULL,
  `Precio` double NOT NULL,
  `CantidadMaxima` int(11) DEFAULT NULL,
  `FechaFinaliza` datetime DEFAULT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdPromocion`),
  KEY `IdUsuario` (`IdUsuario`),
  KEY `IdDetallePromo` (`IdDetallePromo`),
  CONSTRAINT `promocion_ibfk_1` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`),
  CONSTRAINT `promocion_ibfk_2` FOREIGN KEY (`IdDetallePromo`) REFERENCES `detallepromo` (`IdDetallePromo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promocion`
--

LOCK TABLES `promocion` WRITE;
/*!40000 ALTER TABLE `promocion` DISABLE KEYS */;
/*!40000 ALTER TABLE `promocion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provedor`
--

DROP TABLE IF EXISTS `provedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `provedor` (
  `IdProvedor` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Marca` varchar(30) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Web` varchar(100) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  `IdCiudad` int(11) NOT NULL,
  PRIMARY KEY (`IdProvedor`),
  KEY `IdCiudad` (`IdCiudad`),
  CONSTRAINT `provedor_ibfk_1` FOREIGN KEY (`IdCiudad`) REFERENCES `ciudad` (`IdCiudad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provedor`
--

LOCK TABLES `provedor` WRITE;
/*!40000 ALTER TABLE `provedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `provedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reportesequipos`
--

DROP TABLE IF EXISTS `reportesequipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reportesequipos` (
  `IdReporte` int(11) NOT NULL AUTO_INCREMENT,
  `IdEquipo` int(11) NOT NULL,
  `IdUsuario` int(11) NOT NULL,
  `IdEmpleado` int(11) DEFAULT NULL,
  `Descripcion` varchar(150) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdReporte`),
  KEY `IdEquipo` (`IdEquipo`),
  KEY `IdUsuario` (`IdUsuario`),
  CONSTRAINT `reportesequipos_ibfk_1` FOREIGN KEY (`IdEquipo`) REFERENCES `equipo` (`IdEquipo`),
  CONSTRAINT `reportesequipos_ibfk_2` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reportesequipos`
--

LOCK TABLES `reportesequipos` WRITE;
/*!40000 ALTER TABLE `reportesequipos` DISABLE KEYS */;
/*!40000 ALTER TABLE `reportesequipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoempleado`
--

DROP TABLE IF EXISTS `tipoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoempleado` (
  `IdTipoEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(30) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdTipoEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoempleado`
--

LOCK TABLES `tipoempleado` WRITE;
/*!40000 ALTER TABLE `tipoempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipoempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipomembrecia`
--

DROP TABLE IF EXISTS `tipomembrecia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipomembrecia` (
  `IdTipoMembrecia` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `Duracion` int(11) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdTipoMembrecia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipomembrecia`
--

LOCK TABLES `tipomembrecia` WRITE;
/*!40000 ALTER TABLE `tipomembrecia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipomembrecia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipousuario`
--

DROP TABLE IF EXISTS `tipousuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipousuario` (
  `IdTipo` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  `Estatus` varchar(1) DEFAULT 'A',
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdTipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipousuario`
--

LOCK TABLES `tipousuario` WRITE;
/*!40000 ALTER TABLE `tipousuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipousuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidadmedida`
--

DROP TABLE IF EXISTS `unidadmedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidadmedida` (
  `IdUnidadMedida` int(11) NOT NULL AUTO_INCREMENT,
  `Medida` varchar(5) NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdUnidadMedida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidadmedida`
--

LOCK TABLES `unidadmedida` WRITE;
/*!40000 ALTER TABLE `unidadmedida` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidadmedida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int(11) DEFAULT NULL,
  `IdTipo` int(11) NOT NULL,
  `Nom` varchar(20) DEFAULT NULL,
  `Apm` varchar(20) DEFAULT NULL,
  `App` varchar(20) DEFAULT NULL,
  `Tel` varchar(10) DEFAULT NULL,
  `Pass` tinyblob NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`IdUsuario`),
  KEY `IdEmpleado` (`IdEmpleado`),
  KEY `IdTipo` (`IdTipo`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleado` (`IdEmpleado`),
  CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`IdTipo`) REFERENCES `tipousuario` (`IdTipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `venta` (
  `IdVenta` int(11) NOT NULL,
  `IdDetalle` int(11) NOT NULL,
  `IdUsuario` int(11) NOT NULL,
  `IdCliente` int(11) NOT NULL,
  `CantidadProducto` int(11) NOT NULL,
  `Iva` double DEFAULT NULL,
  `Total` double NOT NULL,
  `FechaRegistro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estatus` varchar(1) NOT NULL DEFAULT 'A',
  `Subtotal` double NOT NULL,
  PRIMARY KEY (`IdVenta`),
  KEY `IdCliente` (`IdCliente`),
  KEY `IdUsuario` (`IdUsuario`),
  KEY `IdDetalle` (`IdDetalle`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`),
  CONSTRAINT `venta_ibfk_2` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`),
  CONSTRAINT `venta_ibfk_3` FOREIGN KEY (`IdDetalle`) REFERENCES `detalleventa` (`IdDetalle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bdgym'
--

--
-- Dumping routines for database 'bdgym'
--
/*!50003 DROP PROCEDURE IF EXISTS `CProducto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CProducto`(
_codigo varchar(10)
)
BEGIN
select *from producto where Codigo=_codigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `probando` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `probando`(
nombre varchar(20),
NombreCom varchar(20),
telefono varchar(10)
)
BEGIN


insert into infogeneral(infogeneral.Nombre,infogeneral.NombreComercial,infogeneral.Telefono)values(nombre,NombreCom,telefono);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-25 13:04:31
