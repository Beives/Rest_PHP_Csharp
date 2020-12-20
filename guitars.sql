-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 20. 13:55
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `rest_guitars`
--
CREATE DATABASE IF NOT EXISTS `rest_guitars` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `rest_guitars`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gitar`
--

CREATE TABLE `gitar` (
  `id` int(11) NOT NULL,
  `marka` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `forma` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `bundok` int(10) NOT NULL,
  `hangszedo` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `hurok` int(10) NOT NULL,
  `tipus` varchar(25) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- A tábla adatainak kiíratása `gitar`
--

INSERT INTO `gitar` (`id`, `marka`, `forma`, `bundok`, `hangszedo`, `hurok`, `tipus`) VALUES
(1, 'Ibanez', 'Soloist', 24, 'Infinity-R H-H', 7, 'GRG7221QA-TKS'),
(2, 'Jackson', 'Flying-V', 24, 'Seymour Duncan Blackout', 6, 'kv6'),
(4, 'Jackson', 'Custom', 24, 'EMG H4 + Jackson', 6, 'Warrior');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(13, 'admin', '21232f297a57a5a743894a0e4a801fc3'),
(15, 'root', '63a9f0ea7bb98050796b649e85481845');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `gitar`
--
ALTER TABLE `gitar`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `gitar`
--
ALTER TABLE `gitar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
