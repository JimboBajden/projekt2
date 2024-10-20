-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 20 Paź 2024, 19:18
-- Wersja serwera: 10.4.25-MariaDB
-- Wersja PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `projekt`
--
CREATE DATABASE IF NOT EXISTS `projekt` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `projekt`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `osoby`
--

CREATE TABLE `osoby` (
  `id` int(11) NOT NULL,
  `imie` varchar(255) DEFAULT NULL,
  `nazwisko` varchar(255) DEFAULT NULL,
  `numerTelefonu` varchar(255) DEFAULT NULL,
  `adres` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `osoby`
--

INSERT INTO `osoby` (`id`, `imie`, `nazwisko`, `numerTelefonu`, `adres`) VALUES
(15, 'test2', 'testowiec2', '152353453', 'miejsce2'),
(16, 'test', 'testowe', '2137231513', 'miejsce'),
(17, 'test2', 'testowiec2', '152353453', 'miejsce2'),
(18, 'gre', 'gregowski', '21343256', 'miejsce 23'),
(19, 'Jan', 'Kowalski', '123456789', 'ul. Nowa 5, Warszawa'),
(20, 'Anna', 'Nowak', '987654321', 'ul. Stara 12, Kraków'),
(21, 'Piotr', 'Wiśniewski', '654321987', 'ul. Zielona 8, Gdańsk'),
(22, 'Maria', 'Lewandowska', '111222333', 'ul. Słoneczna 9, Poznań'),
(23, 'Tomasz', 'Kamiński', '444555666', 'ul. Wesoła 2, Wrocław'),
(24, 'Katarzyna', 'Zielińska', '777888999', 'ul. Jasna 10, Łódź'),
(25, 'Michał', 'Szymański', '999888777', 'ul. Krótka 3, Lublin'),
(26, 'Agnieszka', 'Wójcik', '555666777', 'ul. Długa 15, Szczecin'),
(27, 'Robert', 'Kozłowski', '333444555', 'ul. Spokojna 7, Bydgoszcz'),
(28, 'Paweł', 'Jankowski', '222333444', 'ul. Leśna 11, Katowice'),
(29, 'osobnik', 'nazwisko', '213515632', 'miejsce');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `osoby`
--
ALTER TABLE `osoby`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `osoby`
--
ALTER TABLE `osoby`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
