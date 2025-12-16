/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE IF NOT EXISTS `livraria2si` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci */;
USE `livraria2si`;

DELIMITER //
CREATE PROCEDURE `altera_Cliente`(in novoNome varchar(200),novaData Varchar(100),novoCpf varchar(20), novoUf varchar(2),novoEnd varchar(100) , novoBairro varchar(100), novaCity varchar(45), novoCep varchar(20), novoEmail varchar(200), in codigo int)
BEGIN
    update cliente set nome = novoNome, dataNascimento = novaData , cpf = novoCpf, uf = novoUf, endereco = novoEnd, bairro = novoBairro, cidade = novaCity, cep = novoCep, email = novoEmail where codCliente = codigo; 
END//
DELIMITER ;

CREATE TABLE IF NOT EXISTS `categoria` (
  `codCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`codCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

INSERT INTO `categoria` (`codCategoria`, `nome`) VALUES
    (1, 'Ficção Científica'),
    (2, 'Romance'),
    (3, 'Terror'),
    (4, 'Fantasia'),
    (5, 'Técnico'),
    (6, 'HQs e Mangás');

CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `dataNascimento` varchar(100) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `uf` char(2) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `email` varchar(200) NOT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

INSERT INTO `cliente` (`codCliente`, `nome`, `dataNascimento`, `cpf`, `uf`, `endereco`, `bairro`, `cidade`, `cep`, `email`) VALUES
    (1, 'Bruce Wayne', '1980-02-19', '111.222.333-44', 'SP', 'Rua das Mansões, 100', 'Jardins', 'São Paulo', '01000-000', 'batman@wayne.com'),
    (2, 'Tony Stark', '1975-05-29', '555.666.777-88', 'RJ', 'Av. Atlântica, 5000', 'Copacabana', 'Rio de Janeiro', '22000-000', 'ironman@stark.com'),
    (3, 'Peter Parker', '2001-08-10', '999.888.777-66', 'NY', 'Rua Humilde, 20', 'Queens', 'Nova Iorque', '30000-000', 'spidey@web.com'),
    (4, 'Clark Kent', '1985-06-18', '123.456.789-00', 'KS', 'Fazenda Kent', 'Smallville', 'Kansas', '40000-000', 'super@dailyplanet.com'),
    (5, 'Diana Prince', '1000-01-01', '000.000.000-01', 'DF', 'Embaixada, 1', 'Asa Sul', 'Brasília', '70000-000', 'ww@amazon.com'),
    (6, 'Natasha Romanoff', '1984-11-22', '222.333.444-55', 'ES', 'Rua Secreta, 007', 'Centro', 'Vitória', '29000-000', 'natasha@shield.com'),
    (7, 'Steve Rogers', '1918-07-04', '111.111.111-11', 'MG', 'Rua da Liberdade, 70', 'Savassi', 'Belo Horizonte', '30000-000', 'cap@avengers.com'),
    (8, 'Wanda Maximoff', '1989-02-10', '666.777.888-99', 'RS', 'Av. da Magia, 900', 'Moinhos', 'Porto Alegre', '90000-000', 'wanda@vision.com');

DELIMITER //
CREATE PROCEDURE `consultaLogin`(usuario varchar(100), senha varchar(100))
BEGIN
Select * from usuarios where usuarios.nome = usuario and usuarios.senha = senha;
END//
DELIMITER ;

CREATE TABLE IF NOT EXISTS `editora` (
  `codEditora` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  PRIMARY KEY (`codEditora`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

INSERT INTO `editora` (`codEditora`, `nome`) VALUES
    (1, 'Companhia das Letras'),
    (2, 'Darkside Books'),
    (3, 'Aleph'),
    (4, 'Intrínseca'),
    (5, 'Rocco'),
    (6, 'Panini'),
    (7, 'Sextante'),
    (8, 'Arqueiro'),
    (9, 'Suma');

DELIMITER //
CREATE PROCEDURE `insere_cliente`(in nome varchar(200), dataNascimento varchar(100), cpf varchar(20), uf varchar(2), endereco varchar(100), bairro varchar(100), cidade varchar(45), cep varchar(20), email varchar(200))
BEGIN
    insert into cliente values (null,
