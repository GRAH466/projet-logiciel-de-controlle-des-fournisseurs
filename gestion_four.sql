-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 18 nov. 2024 à 16:52
-- Version du serveur : 8.0.31
-- Version de PHP : 8.1.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_four`
--
CREATE DATABASE IF NOT EXISTS `gestion_four` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `gestion_four`;

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `Num_cmde` int NOT NULL AUTO_INCREMENT,
  `Date_cmde` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Montant` decimal(10,2) NOT NULL,
  `NumF` int NOT NULL,
  `Code_prdt` int NOT NULL,
  `Quantite` int NOT NULL,
  PRIMARY KEY (`Num_cmde`),
  KEY `fk_NumF` (`NumF`),
  KEY `fk_commande_produit` (`Code_prdt`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`Num_cmde`, `Date_cmde`, `Montant`, `NumF`, `Code_prdt`, `Quantite`) VALUES
(1, '2024-11-07 04:10:40', '10000.00', 4, 4, 5),
(2, '2024-11-07 04:46:19', '700.00', 4, 3, 7),
(3, '2024-11-07 04:53:37', '4000.00', 1, 4, 2),
(4, '2024-11-07 05:01:56', '600.00', 1, 3, 6),
(5, '2024-11-07 05:37:22', '40000.00', 5, 5, 8),
(6, '2024-11-07 05:40:53', '14000.00', 5, 4, 7),
(7, '2024-11-07 06:11:11', '25000.00', 4, 5, 5),
(8, '2024-11-07 06:13:54', '10000.00', 1, 5, 2),
(9, '2024-11-07 06:50:52', '4000.00', 1, 4, 2),
(10, '2024-11-07 07:04:31', '2000.00', 1, 4, 1),
(11, '2024-11-14 14:32:53', '30000.00', 1, 6, 3);

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `NumF` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Adresse` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`NumF`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`NumF`, `Nom`, `Adresse`) VALUES
(1, 'Baltazar', 'Guine'),
(5, 'Sidibe', 'ABIDJAN'),
(4, 'Diallo', 'BOUAKE'),
(6, 'Fournisseur', 'INDE');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `Code_prdt` int NOT NULL AUTO_INCREMENT,
  `Designation` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Reference` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Quantite` int NOT NULL,
  `Prix` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Code_prdt`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`Code_prdt`, `Designation`, `Reference`, `Quantite`, `Prix`) VALUES
(3, 'Eau', 'H20', 6, '100.00'),
(5, 'Spaguetti', 'SPA01', 17, '5000.00'),
(6, 'PC', 'PC001', 10, '10000.00');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
