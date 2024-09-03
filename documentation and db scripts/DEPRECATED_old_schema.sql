-- MySQL dump 10.13  Distrib 5.5.39, for Win32 (x86)
--
-- Host: localhost    Database: veraprint
-- ------------------------------------------------------
-- Server version	5.5.39

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
-- Table structure for table `adresy_dostaw`
--

DROP TABLE IF EXISTS `adresy_dostaw`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `adresy_dostaw` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ulica` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nr_domu` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nr_mieszkania` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kraj` varchar(6) COLLATE utf8_unicode_ci NOT NULL DEFAULT 'PL',
  `domyslny_adres` tinyint(4) DEFAULT '0',
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `adresy_dostaw_FI_1` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=770 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cennik`
--

DROP TABLE IF EXISTS `cennik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cennik` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `konfiguracja` text COLLATE utf8_unicode_ci,
  `nazwa` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kategorie_id` int(11) DEFAULT NULL,
  `formaty_id` int(11) DEFAULT NULL,
  `domyslny` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `cennik_FI_1` (`kategorie_id`),
  KEY `cennik_FI_2` (`formaty_id`)
) ENGINE=MyISAM AUTO_INCREMENT=50 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cennik_przesylek`
--

DROP TABLE IF EXISTS `cennik_przesylek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cennik_przesylek` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rodzaje_dostawy_id` int(11) NOT NULL DEFAULT '0',
  `kraje_id` int(11) NOT NULL DEFAULT '0',
  `waluta` varchar(3) DEFAULT NULL,
  `kwota_brutto` varchar(20) DEFAULT NULL,
  `domyslna` tinyint(4) NOT NULL DEFAULT '0',
  `kolejnosc` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `cennik_przesylek_FI_1` (`rodzaje_dostawy_id`),
  KEY `cennik_przesylek_FI_2` (`kraje_id`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cennik_przesylek_klientow`
--

DROP TABLE IF EXISTS `cennik_przesylek_klientow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cennik_przesylek_klientow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rodzaje_dostawy_id` int(11) NOT NULL DEFAULT '0',
  `kraje_id` int(11) NOT NULL DEFAULT '0',
  `uzytkownicy_id` int(11) DEFAULT NULL,
  `kwota_brutto` varchar(20) DEFAULT NULL,
  `czy_darmowa_dostawa` tinyint(4) NOT NULL DEFAULT '0',
  `kwota_zamowienia_darmowej_dostawy` varchar(10) DEFAULT NULL,
  `kolejnosc` int(11) NOT NULL DEFAULT '0',
  `czy_domyslne` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `cennik_przesylek_klientow_FI_1` (`rodzaje_dostawy_id`),
  KEY `cennik_przesylek_klientow_FI_2` (`kraje_id`),
  KEY `cennik_przesylek_klientow_FI_3` (`uzytkownicy_id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cenniki`
--

DROP TABLE IF EXISTS `cenniki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cenniki` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(255) NOT NULL,
  `konfiguracja` longtext,
  `konfiguracja2` longtext,
  `konfiguracja3` longtext,
  `przesylki` longtext NOT NULL,
  `grupy` longtext NOT NULL,
  `grupowanie` longtext,
  `grupowanie2` longtext,
  `grupowanie3` longtext,
  `grupy_uzytkownikow` longtext,
  `nazwa_przestrzeni` varchar(255) NOT NULL DEFAULT 'Zakres 1',
  `nazwa_przestrzeni2` varchar(255) NOT NULL DEFAULT 'Zakres 2',
  `nazwa_przestrzeni3` varchar(255) NOT NULL DEFAULT 'Zakres 3',
  `uuid_przestrzeni` int(11) NOT NULL DEFAULT '1',
  `uuid_przestrzeni2` int(11) NOT NULL DEFAULT '2',
  `uuid_przestrzeni3` int(11) NOT NULL DEFAULT '3',
  `aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `cenniki_I_1` (`uuid_przestrzeni`),
  KEY `cenniki_I_2` (`uuid_przestrzeni2`),
  KEY `cenniki_I_3` (`uuid_przestrzeni3`)
) ENGINE=InnoDB AUTO_INCREMENT=189 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `centra_kosztowe`
--

DROP TABLE IF EXISTS `centra_kosztowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centra_kosztowe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_user` int(11) NOT NULL DEFAULT '0',
  `nazwa` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `centra_kosztowe_FI_1` (`id_user`),
  CONSTRAINT `centra_kosztowe_FK_1` FOREIGN KEY (`id_user`) REFERENCES `uzytkownicy` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `centra_nazwy`
--

DROP TABLE IF EXISTS `centra_nazwy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centra_nazwy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_centra` int(11) NOT NULL DEFAULT '0',
  `nazwa` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `centra_nazwy_FI_1` (`id_centra`),
  CONSTRAINT `centra_nazwy_FK_1` FOREIGN KEY (`id_centra`) REFERENCES `centra_kosztowe` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=209 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `centra_wybrane`
--

DROP TABLE IF EXISTS `centra_wybrane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centra_wybrane` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_user` int(11) NOT NULL DEFAULT '0',
  `id_centrak` int(11) NOT NULL DEFAULT '0',
  `id_centran` int(11) NOT NULL DEFAULT '0',
  `czy_domyslne` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `centra_wybrane_FI_1` (`id_user`),
  KEY `centra_wybrane_FI_2` (`id_centrak`),
  KEY `centra_wybrane_FI_3` (`id_centran`),
  CONSTRAINT `centra_wybrane_FK_1` FOREIGN KEY (`id_user`) REFERENCES `uzytkownicy` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `centra_wybrane_FK_2` FOREIGN KEY (`id_centrak`) REFERENCES `centra_kosztowe` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `centra_wybrane_FK_3` FOREIGN KEY (`id_centran`) REFERENCES `centra_nazwy` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=138 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `czcionki`
--

DROP TABLE IF EXISTS `czcionki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `czcionki` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(50) DEFAULT NULL,
  `ttf_normal_path` varchar(150) DEFAULT NULL,
  `ttf_bold_path` varchar(150) DEFAULT NULL,
  `ttf_italic_path` varchar(150) DEFAULT NULL,
  `ttf_bold_italic_path` varchar(150) DEFAULT NULL,
  `otf_normal_path` varchar(150) DEFAULT NULL,
  `otf_bold_path` varchar(150) DEFAULT NULL,
  `otf_italic_path` varchar(150) DEFAULT NULL,
  `otf_bold_italic_path` varchar(150) DEFAULT NULL,
  `eot_normal_path` varchar(150) DEFAULT NULL,
  `eot_bold_path` varchar(150) DEFAULT NULL,
  `eot_italic_path` varchar(150) DEFAULT NULL,
  `eot_bold_italic_path` varchar(150) DEFAULT NULL,
  `woff_normal_path` varchar(150) DEFAULT NULL,
  `woff_bold_path` varchar(150) DEFAULT NULL,
  `woff_italic_path` varchar(150) DEFAULT NULL,
  `woff_bold_italic_path` varchar(150) DEFAULT NULL,
  `openfont` tinyint(4) NOT NULL DEFAULT '1',
  `domyslna` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=255 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `danetestowe`
--

DROP TABLE IF EXISTS `danetestowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `danetestowe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `etykieta` varchar(20) DEFAULT NULL,
  `text` varchar(100) DEFAULT NULL,
  `typ` int(11) DEFAULT NULL,
  `szablonyproduktow_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `danetestowe_FI_1` (`szablonyproduktow_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `emails`
--

DROP TABLE IF EXISTS `emails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `emails` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) DEFAULT NULL,
  `typ` int(11) DEFAULT NULL,
  `rodzajemaili_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `emails_FI_1` (`rodzajemaili_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `etykietyproduktyzapisane`
--

DROP TABLE IF EXISTS `etykietyproduktyzapisane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `etykietyproduktyzapisane` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `klient_id` int(11) NOT NULL,
  `nazwa` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `etykietyproduktyzapisane_FI_1` (`klient_id`)
) ENGINE=MyISAM AUTO_INCREMENT=185 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `faktura`
--

DROP TABLE IF EXISTS `faktura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faktura` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numer_faktury` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `numer_referencyjny` varchar(400) COLLATE utf8_unicode_ci DEFAULT '',
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `kto_utworzyl` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  `data_wysylki` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `kto_wyslal` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  `data_ostatniej_wysylki` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `kto_ostatnio_wyslal` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  `zatwierdz_platnosc` tinyint(4) DEFAULT '0',
  `data_zatwierdzenia_platnosci` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `czy_zaplacono` tinyint(4) DEFAULT '1',
  `opis` varchar(100) COLLATE utf8_unicode_ci DEFAULT ' FAKTURA VAT',
  `rodzaj_opis` varchar(100) COLLATE utf8_unicode_ci DEFAULT 'ORYGINAŁ/KOPIA',
  `data_wystawienia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_sprzedazy` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_zaplaty` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `forma_platnosci` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_brutto` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_zaplaty` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `zaplacono` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_brutto_slownie` varchar(300) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_netto` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_vat` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `vat` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `przesylka_kwota_brutto` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `numer_rachunku_bankowego` varchar(100) COLLATE utf8_unicode_ci DEFAULT '',
  `swift_code` varchar(15) COLLATE utf8_unicode_ci DEFAULT '',
  `s_imie_nazwisko` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `przesylka_kwota_netto` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s_nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s_kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s_miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s_adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `s_nip` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_nazwa_firmy_lub_osoby` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_nip` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `uwagi` text COLLATE utf8_unicode_ci,
  `uid` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `czy_koszty` tinyint(4) NOT NULL DEFAULT '0',
  `waluta` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `sprzedawca_id` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17663 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `faktura_zalacznik`
--

DROP TABLE IF EXISTS `faktura_zalacznik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faktura_zalacznik` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `faktura_id` int(11) DEFAULT NULL,
  `numer_faktury` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `opis` varchar(100) COLLATE utf8_unicode_ci DEFAULT 'Załącznik do Faktury VAT',
  `rodzaj_opis` varchar(100) COLLATE utf8_unicode_ci DEFAULT 'ORYGINAŁ/KOPIA',
  `data_wystawienia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_nazwa_firmy_lub_osoby` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `n_nip` varchar(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `uwagi` text COLLATE utf8_unicode_ci,
  `uid` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `faktura_zalacznik_FI_1` (`faktura_id`),
  CONSTRAINT `faktura_zalacznik_FK_1` FOREIGN KEY (`faktura_id`) REFERENCES `faktura` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19798 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `filtry`
--

DROP TABLE IF EXISTS `filtry`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `filtry` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `grupa` varchar(255) NOT NULL,
  `nazwa` varchar(255) NOT NULL,
  `wartosc` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `formaty`
--

DROP TABLE IF EXISTS `formaty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formaty` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(20) DEFAULT NULL,
  `wymiarmm_x` int(11) DEFAULT NULL,
  `wymiarmm_y` int(11) DEFAULT NULL,
  `wymiarpx_x` int(11) DEFAULT NULL,
  `wymiarpx_y` int(11) DEFAULT NULL,
  `wymiarminiatury_x` int(11) DEFAULT NULL,
  `wymiarminiatury_y` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `identyfikatory`
--

DROP TABLE IF EXISTS `identyfikatory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `identyfikatory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `wartosc` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `typ` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kampania_mailingowa`
--

DROP TABLE IF EXISTS `kampania_mailingowa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kampania_mailingowa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `domyslny_layout` tinyint(4) DEFAULT '0',
  `nazwa_kampanii` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_uruchomienia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_zakonczenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` tinyint(4) DEFAULT '0',
  `landingpage_css` text COLLATE utf8_unicode_ci,
  `landingpage_html` text COLLATE utf8_unicode_ci,
  `cennik_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `kampania_mailingowa_FI_1` (`cennik_id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kampania_mailingowa_statystyka`
--

DROP TABLE IF EXISTS `kampania_mailingowa_statystyka`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kampania_mailingowa_statystyka` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ilosc_wejsc` int(11) DEFAULT NULL,
  `kampania_mailingowa_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `kampania_mailingowa_statystyka_FI_1` (`kampania_mailingowa_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kategorie`
--

DROP TABLE IF EXISTS `kategorie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kategorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(30) DEFAULT NULL,
  `opis` varchar(200) DEFAULT NULL,
  `grafika` varchar(150) DEFAULT NULL,
  `margines` int(11) NOT NULL DEFAULT '10',
  `margines_wewnetrzny` int(11) NOT NULL DEFAULT '5',
  `ilosc_stron` int(11) NOT NULL DEFAULT '2',
  `typproduktu` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `klienci`
--

DROP TABLE IF EXISTS `klienci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klienci` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `haslo` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `skrot` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fnazwafirmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fulica` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fnrdomu` varchar(4) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fnrlokalu` varchar(4) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fkodpocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fmiasto` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fnip` varchar(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ftelfax` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ftel` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `femail` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fwww` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wnazwafirmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wulica` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wnrdomu` varchar(4) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wnrlokalu` varchar(4) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wkodpocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wmiasto` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wnip` varchar(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wtelfax` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wtel` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wemail` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wwww` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kimie` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `knazwisko` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kfax` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ktel` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kemail` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwww` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `klientcennik`
--

DROP TABLE IF EXISTS `klientcennik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klientcennik` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uzytkownicy_id` int(11) DEFAULT NULL,
  `cennik_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `klientcennik_FI_1` (`uzytkownicy_id`),
  KEY `klientcennik_FI_2` (`cennik_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3168 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kody_program_partnerski`
--

DROP TABLE IF EXISTS `kody_program_partnerski`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kody_program_partnerski` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kod` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_wykorzystania` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `aktywny` tinyint(4) DEFAULT '1',
  `parent_user_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `kody_program_partnerski_FI_1` (`parent_user_id`),
  KEY `kody_program_partnerski_FI_2` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=38 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `komentarzeproduktyzamowienie`
--

DROP TABLE IF EXISTS `komentarzeproduktyzamowienie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `komentarzeproduktyzamowienie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `opis` varchar(1000) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` int(11) DEFAULT '0',
  `produktyzamowienie_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `komentarzeproduktyzamowienie_FI_1` (`produktyzamowienie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=138 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `konfiguracja_uzytkownika`
--

DROP TABLE IF EXISTS `konfiguracja_uzytkownika`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konfiguracja_uzytkownika` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uzytkownicy_id` int(11) DEFAULT NULL,
  `konfiguracja` mediumtext COLLATE utf8_unicode_ci,
  PRIMARY KEY (`id`),
  KEY `konfiguracja_uzytkownika_FI_1` (`uzytkownicy_id`)
) ENGINE=MyISAM AUTO_INCREMENT=634 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `konfiguracjaczcionek`
--

DROP TABLE IF EXISTS `konfiguracjaczcionek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konfiguracjaczcionek` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konfiguracja` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `konkursy`
--

DROP TABLE IF EXISTS `konkursy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konkursy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa_konkursu` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_od` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_do` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `aktywny` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `konta_bankowe_konfiguracja`
--

DROP TABLE IF EXISTS `konta_bankowe_konfiguracja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `konta_bankowe_konfiguracja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(100) DEFAULT NULL,
  `numer_konta` varchar(35) DEFAULT NULL,
  `swift_code` varchar(10) DEFAULT NULL,
  `czy_domyslne` tinyint(4) NOT NULL DEFAULT '0',
  `visible` tinyint(4) NOT NULL DEFAULT '1',
  `sprzedawca_id` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kontrahenci`
--

DROP TABLE IF EXISTS `kontrahenci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kontrahenci` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `root_user_id` int(11) NOT NULL,
  `nazwa` varchar(255) DEFAULT NULL,
  `nazwa_kontrahenta` varchar(255) DEFAULT NULL,
  `adres` varchar(255) DEFAULT NULL,
  `kod_pocztowy` varchar(12) DEFAULT NULL,
  `miejscowosc` varchar(255) DEFAULT NULL,
  `nip` varchar(20) DEFAULT NULL,
  `domyslny` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=502 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kontrahenci_wybrani`
--

DROP TABLE IF EXISTS `kontrahenci_wybrani`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kontrahenci_wybrani` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kontrahent_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `domyslny` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `kontrahenci_wybrani_FI_1` (`kontrahent_id`),
  CONSTRAINT `kontrahenci_wybrani_FK_1` FOREIGN KEY (`kontrahent_id`) REFERENCES `kontrahenci` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=308 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `koszyk`
--

DROP TABLE IF EXISTS `koszyk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `koszyk` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data_ostatniej_aktywnosci` varchar(20) DEFAULT NULL,
  `uid` varchar(255) DEFAULT NULL,
  `uuid_przestrzeni` int(11) NOT NULL DEFAULT '1',
  `status` int(11) DEFAULT '0',
  `data_statusu` varchar(20) DEFAULT NULL,
  `uzytkownicy_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `koszyk_FI_1` (`uzytkownicy_id`),
  KEY `koszyk_I_1` (`uuid_przestrzeni`)
) ENGINE=MyISAM AUTO_INCREMENT=18620 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kraje`
--

DROP TABLE IF EXISTS `kraje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kraje` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(50) DEFAULT '',
  `nazwa_en` varchar(50) DEFAULT '',
  `nazwa_de` varchar(50) DEFAULT '',
  `kod` varchar(10) DEFAULT '',
  `kolejnosc` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=40 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kryteriasortowania`
--

DROP TABLE IF EXISTS `kryteriasortowania`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kryteriasortowania` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `order` int(11) DEFAULT '0',
  `type` int(11) DEFAULT '0',
  `konfiguracja` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=57 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kuponyrabatowe`
--

DROP TABLE IF EXISTS `kuponyrabatowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kuponyrabatowe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kodkuponu` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `krotnoscuzycia` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `krotnoscwykorzystania` varchar(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '0',
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_waznosci` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `typkuponu` int(11) DEFAULT NULL,
  `wartosc1` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wartosc2` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `typ` int(11) DEFAULT '2',
  `status` int(11) DEFAULT '2',
  `uzytkownicy_id` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kuponyrabatowerezerwacja`
--

DROP TABLE IF EXISTS `kuponyrabatowerezerwacja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kuponyrabatowerezerwacja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data_rezerwacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kuponyrabatowe_id` int(11) DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `kuponyrabatowerezerwacja_FI_1` (`kuponyrabatowe_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `logasadmin`
--

DROP TABLE IF EXISTS `logasadmin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `logasadmin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=16451 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `newsletteruzytkownicy`
--

DROP TABLE IF EXISTS `newsletteruzytkownicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `newsletteruzytkownicy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sumakontrolna` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `active` tinyint(4) DEFAULT '0',
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_aktywacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_rejestracji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `opinie`
--

DROP TABLE IF EXISTS `opinie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `opinie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_zatwierdzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `opinia` text COLLATE utf8_unicode_ci,
  `uwagi` text COLLATE utf8_unicode_ci,
  `pytanie_1` varchar(6) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pytanie_2` varchar(6) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pytanie_3` varchar(6) COLLATE utf8_unicode_ci DEFAULT NULL,
  `login` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `facebook_post_id` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `facebook_page_id` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `aktywna_na_stronie` tinyint(4) DEFAULT '0',
  `aktywna_na_facebook` tinyint(4) DEFAULT '0',
  `uzytkownicy_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `opinie_FI_1` (`uzytkownicy_id`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `paczkomaty`
--

DROP TABLE IF EXISTS `paczkomaty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paczkomaty` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ulica` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `miejscowosc` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `numer_budynku` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=15188458 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `paczkomaty_konfiguracja`
--

DROP TABLE IF EXISTS `paczkomaty_konfiguracja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paczkomaty_konfiguracja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konfiguracja` longtext COLLATE utf8_unicode_ci,
  `konfiguracja_tymczasowa` longtext COLLATE utf8_unicode_ci,
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_aktualizacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1803 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `papier`
--

DROP TABLE IF EXISTS `papier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `papier` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `opis` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rozszerzony_opis` text COLLATE utf8_unicode_ci,
  `czas_realizacji` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ikona_path` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `big_ikona_path` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `numer` int(11) DEFAULT NULL,
  `nazwa` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `liczbastron` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `parametry_produktow`
--

DROP TABLE IF EXISTS `parametry_produktow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parametry_produktow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `typ` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `pokaz` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `podkategorie`
--

DROP TABLE IF EXISTS `podkategorie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `podkategorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `opis` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `visible` tinyint(4) NOT NULL DEFAULT '0',
  `kategorie_id` int(11) DEFAULT NULL,
  `formaty_id` int(11) DEFAULT NULL,
  `podkategoria_glowna_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `podkategorie_FI_1` (`kategorie_id`),
  KEY `podkategorie_FI_2` (`formaty_id`),
  KEY `podkategorie_FI_3` (`podkategoria_glowna_id`)
) ENGINE=MyISAM AUTO_INCREMENT=297 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `podkategorieseo`
--

DROP TABLE IF EXISTS `podkategorieseo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `podkategorieseo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `keywords` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `description` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `header` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `header_desc` text COLLATE utf8_unicode_ci,
  `podkategorie_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=215 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `probkidrukow`
--

DROP TABLE IF EXISTS `probkidrukow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `probkidrukow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `daneadresowe` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_zgloszenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produkty`
--

DROP TABLE IF EXISTS `produkty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produkty` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(255) NOT NULL,
  `ikona_sciezka` varchar(255) NOT NULL DEFAULT '',
  `szablon` text NOT NULL,
  `data_utworzenia` varchar(20) DEFAULT NULL,
  `data_aktualizacji` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=143 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produkty7dniowe`
--

DROP TABLE IF EXISTS `produkty7dniowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produkty7dniowe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konfiguracja` text COLLATE utf8_unicode_ci,
  `salt` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tytul` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `opis` text COLLATE utf8_unicode_ci,
  `dostepna_miniatura` tinyint(4) DEFAULT '0',
  `data_waznosci` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_zapis` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produkty_klientow`
--

DROP TABLE IF EXISTS `produkty_klientow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produkty_klientow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `klient_id` int(11) NOT NULL,
  `nazwa` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `rodzaj_produktu` int(11) NOT NULL,
  `konfiguracja_svg` longtext COLLATE utf8_unicode_ci,
  `wysokosc` int(11) DEFAULT NULL,
  `szerokosc` int(11) DEFAULT NULL,
  `wysokosc2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `szerokosc2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tlo` text COLLATE utf8_unicode_ci,
  `czy_publiczny` tinyint(4) DEFAULT '1',
  `aktywuj_wgrywanie_plikow` tinyint(4) DEFAULT '0',
  `aktywuj_pobieranie_plikow` tinyint(4) DEFAULT '0',
  `plik_pobieranie_path` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `aktywuj_dodanie_do_koszyka` tinyint(4) DEFAULT '0',
  `id_wartosc` int(11) NOT NULL,
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `data_aktualizacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `kto_utworzyl` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  `kto_aktualizowal` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  PRIMARY KEY (`id`),
  KEY `produkty_klientow_FI_1` (`klient_id`),
  KEY `produkty_klientow_FI_2` (`rodzaj_produktu`),
  KEY `produkty_klientow_FI_3` (`id_wartosc`),
  CONSTRAINT `produkty_klientow_FK_1` FOREIGN KEY (`klient_id`) REFERENCES `uzytkownicy` (`id`),
  CONSTRAINT `produkty_klientow_FK_2` FOREIGN KEY (`rodzaj_produktu`) REFERENCES `produkty` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30327 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produkty_parametry`
--

DROP TABLE IF EXISTS `produkty_parametry`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produkty_parametry` (
  `id_produkt` int(11) NOT NULL,
  `id_parametr` int(11) NOT NULL,
  PRIMARY KEY (`id_produkt`,`id_parametr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produkty_wartosci`
--

DROP TABLE IF EXISTS `produkty_wartosci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produkty_wartosci` (
  `id_produkt` int(11) NOT NULL,
  `id_wartosc` int(11) NOT NULL,
  PRIMARY KEY (`id_produkt`,`id_wartosc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktyfaktura`
--

DROP TABLE IF EXISTS `produktyfaktura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktyfaktura` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kwota_netto_przed_rabatem` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_brutto_przed_rabatem` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_netto_po_rabacie` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_brutto_po_rabacie` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `vat` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rabat` int(11) DEFAULT '0',
  `ilosc` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `naklad` varchar(100) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',
  `opis` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `konfiguracja` longtext COLLATE utf8_unicode_ci,
  `faktura_id` int(11) DEFAULT NULL,
  `koszty` text COLLATE utf8_unicode_ci,
  `nazwa_klienta` text COLLATE utf8_unicode_ci,
  `jednostka` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `licz_brutto` int(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `produktyfaktura_FI_1` (`faktura_id`),
  CONSTRAINT `produktyfaktura_FK_1` FOREIGN KEY (`faktura_id`) REFERENCES `faktura` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=69518 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktyfirmowe`
--

DROP TABLE IF EXISTS `produktyfirmowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktyfirmowe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konfiguracja` text,
  `salt` varchar(255) DEFAULT NULL,
  `uzytkownicy_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `produktyfirmowe_FI_1` (`uzytkownicy_id`)
) ENGINE=MyISAM AUTO_INCREMENT=345 DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktykoszyk`
--

DROP TABLE IF EXISTS `produktykoszyk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktykoszyk` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `netto_przed_rabatem` varchar(20) DEFAULT NULL,
  `brutto_przed_rabatem` varchar(20) DEFAULT NULL,
  `vat` varchar(20) DEFAULT NULL,
  `rabat` varchar(20) DEFAULT '0',
  `netto_po_rabacie` varchar(20) DEFAULT NULL,
  `brutto_po_rabacie` varchar(20) DEFAULT NULL,
  `ilosc` int(11) DEFAULT '0',
  `opis` varchar(255) DEFAULT '',
  `konfiguracja` longtext,
  `status` int(11) DEFAULT '0',
  `typproduktu` int(11) DEFAULT '0',
  `koszyk_id` int(11) DEFAULT NULL,
  `koszty` text,
  `nazwa_klienta` text,
  `czas_realizacji_start` int(11) DEFAULT NULL,
  `czas_realizacji_koniec` int(11) DEFAULT NULL,
  `czas_realizacji` int(11) DEFAULT NULL,
  `czas_zrealizowano` int(11) DEFAULT NULL,
  `jednostka` varchar(255) DEFAULT NULL,
  `licz_brutto` int(11) DEFAULT NULL,
  `uid` varchar(255) DEFAULT NULL,
  `kolejnosc` int(11) DEFAULT '1',
  `uzytkownicy_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `produktykoszyk_FI_1` (`koszyk_id`)
) ENGINE=MyISAM AUTO_INCREMENT=46937 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktyzamowienie`
--

DROP TABLE IF EXISTS `produktyzamowienie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktyzamowienie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `netto_przed_rabatem` varchar(20) DEFAULT NULL,
  `brutto_przed_rabatem` varchar(20) DEFAULT NULL,
  `vat` varchar(20) DEFAULT NULL,
  `rabat` varchar(20) DEFAULT '0',
  `netto_po_rabacie` varchar(20) DEFAULT NULL,
  `brutto_po_rabacie` varchar(20) DEFAULT NULL,
  `ilosc` int(11) DEFAULT '0',
  `opis` varchar(255) DEFAULT '',
  `konfiguracja` longtext,
  `status` int(11) DEFAULT '0',
  `typproduktu` int(11) DEFAULT '0',
  `zamowienie_id` int(11) DEFAULT NULL,
  `koszty` text NOT NULL,
  `nazwa_klienta` text NOT NULL,
  `czas_realizacji_start` int(11) NOT NULL,
  `czas_realizacji_koniec` int(11) NOT NULL,
  `czas_realizacji` int(11) NOT NULL DEFAULT '3',
  `czas_zrealizowano` int(11) NOT NULL,
  `jednostka` varchar(255) NOT NULL,
  `licz_brutto` int(11) NOT NULL,
  `uid` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `produktyzamowienie_FI_1` (`zamowienie_id`),
  CONSTRAINT `produktyzamowienie_FK_1` FOREIGN KEY (`zamowienie_id`) REFERENCES `zamowienie` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=67474 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktyzapisane`
--

DROP TABLE IF EXISTS `produktyzapisane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktyzapisane` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uuid_przestrzeni` int(11) NOT NULL DEFAULT '1',
  `klient_id` int(11) NOT NULL,
  `nazwa` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `rodzaj_produktu` int(11) NOT NULL,
  `konfiguracja_svg` longtext COLLATE utf8_unicode_ci,
  `wysokosc` int(11) DEFAULT NULL,
  `szerokosc` int(11) DEFAULT NULL,
  `wysokosc2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `szerokosc2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `etykiety` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `status` int(11) DEFAULT '0',
  `aktywuj_wgrywanie_plikow` tinyint(4) DEFAULT '0',
  `aktywuj_dodanie_do_koszyka` tinyint(4) DEFAULT '0',
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `kto_utworzyl` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  `data_ostatniej_modyfikacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `kto_ostatnio_modyfikowal` varchar(20) COLLATE utf8_unicode_ci DEFAULT 'automat',
  `data_akceptacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT '',
  `email_akceptacji` varchar(100) COLLATE utf8_unicode_ci DEFAULT '',
  `tlo` text COLLATE utf8_unicode_ci,
  `id_wartosc` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `produktyzapisane_FI_1` (`klient_id`),
  KEY `produktyzapisane_FI_2` (`rodzaj_produktu`),
  KEY `produktyzapisane_FI_3` (`id_wartosc`),
  KEY `produktyzapisane_I_1` (`uuid_przestrzeni`),
  CONSTRAINT `produktyzapisane_FK_1` FOREIGN KEY (`klient_id`) REFERENCES `uzytkownicy` (`id`),
  CONSTRAINT `produktyzapisane_FK_2` FOREIGN KEY (`rodzaj_produktu`) REFERENCES `produkty` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29448 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktyzapisaneakceptacja`
--

DROP TABLE IF EXISTS `produktyzapisaneakceptacja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktyzapisaneakceptacja` (
  `data_prosby_o_akceptacje` varchar(20) DEFAULT '',
  `data_waznosci` varchar(20) DEFAULT '',
  `email_prosby_o_akceptacje` varchar(100) DEFAULT '',
  `tytul_emaila` varchar(150) DEFAULT '',
  `uid_prosby` varchar(255) DEFAULT NULL,
  `data_odpowiedzi` varchar(20) DEFAULT '',
  `status` int(11) DEFAULT '0',
  `tresc_prosby` text,
  `tresc_odpowiedzi` text,
  `produktyzapisane_id` int(11) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  KEY `produktyzapisaneakceptacja_FI_1` (`produktyzapisane_id`),
  CONSTRAINT `produktyzapisaneakceptacja_FK_1` FOREIGN KEY (`produktyzapisane_id`) REFERENCES `produktyzapisane` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=716 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produktyzdefiniowane`
--

DROP TABLE IF EXISTS `produktyzdefiniowane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produktyzdefiniowane` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `konfiguracja` text,
  `salt` varchar(255) DEFAULT NULL,
  `uuid_przestrzeni` int(11) NOT NULL DEFAULT '1',
  `szablonyproduktow_id` int(11) DEFAULT NULL,
  `uzytkownicy_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `produktyzdefiniowane_FI_1` (`szablonyproduktow_id`),
  KEY `produktyzdefiniowane_FI_2` (`uzytkownicy_id`),
  KEY `produktyzdefiniowane_I_1` (`uuid_przestrzeni`)
) ENGINE=MyISAM AUTO_INCREMENT=1121 DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `projekty_konkursowe`
--

DROP TABLE IF EXISTS `projekty_konkursowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projekty_konkursowe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `facebook_like` int(11) DEFAULT '0',
  `facebook_share` int(11) DEFAULT '0',
  `facebook_comments` int(11) DEFAULT '0',
  `google_plus` int(11) DEFAULT '0',
  `google_plus_share` int(11) DEFAULT '0',
  `twitter_share` int(11) DEFAULT '0',
  `total` int(11) DEFAULT '0',
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `id_konkursu` int(11) DEFAULT NULL,
  `data_utworzenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_aktualizacji` varchar(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',
  `salt_projektu_tymczasowego` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `id_projektu_tymczasowego` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `projekty_konkursowe_FI_1` (`id_konkursu`),
  KEY `projekty_konkursowe_FI_2` (`id_projektu_tymczasowego`)
) ENGINE=MyISAM AUTO_INCREMENT=97 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `przesylki`
--

DROP TABLE IF EXISTS `przesylki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `przesylki` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `do_imie_nazwisko` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `do_kraj` varchar(6) COLLATE utf8_unicode_ci NOT NULL DEFAULT 'PL',
  `z_nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `z_imie_nazwisko` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `z_adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `z_kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `z_miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `z_telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `z_email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `z_kraj` varchar(6) COLLATE utf8_unicode_ci NOT NULL DEFAULT 'PL',
  `status` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `uid` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `opis` text COLLATE utf8_unicode_ci,
  `typ_pliku` varchar(5) COLLATE utf8_unicode_ci DEFAULT NULL,
  `typ_kuriera` int(11) DEFAULT NULL,
  `typ_przesylki` int(11) NOT NULL DEFAULT '0',
  `zamowienie_kwota_brutto` varchar(10) COLLATE utf8_unicode_ci DEFAULT '0',
  `numer_listu_przewozowego` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `dodatkowe` longtext COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=30440 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `przesylki_konfiguracja`
--

DROP TABLE IF EXISTS `przesylki_konfiguracja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `przesylki_konfiguracja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(100) DEFAULT NULL,
  `kwota_brutto` varchar(10) DEFAULT NULL,
  `czy_darmowa_dostawa` tinyint(4) NOT NULL DEFAULT '0',
  `czy_domyslne` tinyint(4) NOT NULL DEFAULT '0',
  `kwota_zamowienia_darmowej_dostawy` varchar(10) DEFAULT NULL,
  `visible` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `przesylkizamowienia`
--

DROP TABLE IF EXISTS `przesylkizamowienia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `przesylkizamowienia` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `przesylki_id` int(11) DEFAULT NULL,
  `zamowienie_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `przesylkizamowienia_FI_1` (`przesylki_id`),
  KEY `przesylkizamowienia_FI_2` (`zamowienie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=30835 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rodzaje_dostawy`
--

DROP TABLE IF EXISTS `rodzaje_dostawy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rodzaje_dostawy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(50) DEFAULT '',
  `nazwa_en` varchar(50) DEFAULT '',
  `nazwa_de` varchar(50) DEFAULT '',
  `identyfikator` int(11) DEFAULT NULL,
  `kolejnosc` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rodzajemaili`
--

DROP TABLE IF EXISTS `rodzajemaili`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rodzajemaili` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rodzaj` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rodzajepapieru`
--

DROP TABLE IF EXISTS `rodzajepapieru`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rodzajepapieru` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(30) DEFAULT NULL,
  `opis` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rozliczenia`
--

DROP TABLE IF EXISTS `rozliczenia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rozliczenia` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numer_rozliczenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_od` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_do` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_rozliczenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `opis` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_pliku_klienta` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_pliku` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_brutto_zamowien` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_brutto_przesylki` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `podstawa_prowizji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_rozliczenia` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tresc` text COLLATE utf8_unicode_ci,
  `odbiorca_rozliczenia` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `wystawca_rozliczenia` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rozliczone` tinyint(4) DEFAULT '0',
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `rozliczenia_FI_1` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rozliczenia_lista_zamowien`
--

DROP TABLE IF EXISTS `rozliczenia_lista_zamowien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rozliczenia_lista_zamowien` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `zamowienie_id` int(11) DEFAULT '0',
  `rozliczenia_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `rozliczenia_lista_zamowien_FI_1` (`rozliczenia_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `skrzynka_kontaktowa`
--

DROP TABLE IF EXISTS `skrzynka_kontaktowa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `skrzynka_kontaktowa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imie_i_nazwisko` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `adres_email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `temat` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `tresc` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `czy_sprawdzono` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=245 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `statystyka`
--

DROP TABLE IF EXISTS `statystyka`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `statystyka` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pagename` text COLLATE utf8_unicode_ci,
  `shortpagename` varchar(80) COLLATE utf8_unicode_ci DEFAULT NULL,
  `next_pagename` text COLLATE utf8_unicode_ci,
  `next_shortpagename` varchar(80) COLLATE utf8_unicode_ci DEFAULT NULL,
  `timestamp` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `howlong` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `requesttype` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `lastpage` tinyint(4) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `statystyki_zamowien`
--

DROP TABLE IF EXISTS `statystyki_zamowien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `statystyki_zamowien` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kwota_zamowienia_zlozone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_zamowienia_oplacone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_zamowienia_struktura_zlozone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_zamowienia_struktura_oplacone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_przesylka_zlozone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_przesylka_oplacone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_przesylka_struktura_zlozone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kwota_przesylka_struktura_oplacone` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_statystyki` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `struktura_prowizja` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `statystyki_zamowien_FI_1` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `stronastartowa`
--

DROP TABLE IF EXISTS `stronastartowa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stronastartowa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `komunikat` text COLLATE utf8_unicode_ci,
  `slider` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `szablonyopisseo`
--

DROP TABLE IF EXISTS `szablonyopisseo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `szablonyopisseo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `link` varchar(200) COLLATE utf8_unicode_ci DEFAULT '',
  `keywords` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `description` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `opis` text COLLATE utf8_unicode_ci,
  `tagi` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `alt` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `naglowek` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `naglowek_przod` varchar(100) COLLATE utf8_unicode_ci DEFAULT '',
  `naglowek_tyl` varchar(100) COLLATE utf8_unicode_ci DEFAULT '',
  `dlakogo` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `szablon_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1664 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `szablonyproduktow`
--

DROP TABLE IF EXISTS `szablonyproduktow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `szablonyproduktow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `plik_szablonu` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `konfiguracja` text COLLATE utf8_unicode_ci,
  `kategorie_id` int(11) DEFAULT NULL,
  `formaty_id` int(11) DEFAULT NULL,
  `podkategorie_id` int(11) DEFAULT NULL,
  `rank` int(11) NOT NULL,
  `pokaz_w_galerii` tinyint(4) NOT NULL DEFAULT '1',
  `pokaz_na_stronie_glownej_galerii` tinyint(4) NOT NULL DEFAULT '0',
  `tag_name` varchar(50) COLLATE utf8_unicode_ci DEFAULT '',
  `default_reverse_tag` varchar(50) COLLATE utf8_unicode_ci DEFAULT '',
  `reverse_tags` text COLLATE utf8_unicode_ci,
  `options_tags` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`id`),
  KEY `szablonyproduktow_FI_1` (`kategorie_id`),
  KEY `szablonyproduktow_FI_2` (`formaty_id`),
  KEY `szablonyproduktow_FI_3` (`podkategorie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2658 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tempimagegroup`
--

DROP TABLE IF EXISTS `tempimagegroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tempimagegroup` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `plik_grupy` varchar(150) DEFAULT NULL,
  `salt` varchar(150) DEFAULT NULL,
  `datautworzenia` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `uzytkownicy`
--

DROP TABLE IF EXISTS `uzytkownicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uzytkownicy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `parent_user_id` int(11) NOT NULL DEFAULT '0',
  `root_user_id` int(11) DEFAULT '0',
  `domyslna_forma_platnosci` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `login` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `haslo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `sumakontrolna` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `active` tinyint(4) DEFAULT '0',
  `activeeditor` tinyint(4) DEFAULT '1',
  `imie_nazwisko` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon2` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email2_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email2_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email2_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo3` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email3` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko3` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon3` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email3_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email3_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email3_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo4` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email4` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko4` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon4` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email4_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email4_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email4_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo5` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email5` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko5` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon5` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email5_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email5_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email5_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo6` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email6` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko6` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon6` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email6_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email6_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email6_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo7` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email7` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko7` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon7` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email7_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email7_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email7_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo8` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email8` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko8` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon8` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email8_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email8_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email8_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo9` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email10` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko10` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon10` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email10_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email10_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email10_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `email9` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko9` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon9` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email9_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email9_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email9_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo10` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email_aktywna_przestrzen` tinyint(4) DEFAULT '0',
  `email_aktywna_przestrzen2` tinyint(4) DEFAULT '0',
  `email_aktywna_przestrzen3` tinyint(4) DEFAULT '0',
  `haslo2` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email2` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `imie_nazwisko2` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fax` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nip` varchar(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `w_kod_pocztowy` varchar(12) COLLATE utf8_unicode_ci DEFAULT NULL,
  `w_miejscowosc` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `w_adres` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email_do_faktury` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email_do_faktury2` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `czy_wysylac_fakture_email2` tinyint(4) DEFAULT '0',
  `nazwa_ksiegowosci` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon_ksiegowosci` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `czy_akceptuja_fakture_elektroniczna` tinyint(4) DEFAULT '1',
  `notatka_o_platnosciach` text COLLATE utf8_unicode_ci,
  `czy_generowac_fakture_automatycznie` tinyint(4) DEFAULT '0',
  `czy_generowac_fakture_zbiorczo` tinyint(4) DEFAULT '0',
  `termin_platnosci_faktury` varchar(3) COLLATE utf8_unicode_ci NOT NULL DEFAULT '7',
  `czestotliwosc_wystawiania_faktury` tinyint(4) DEFAULT NULL,
  `termin_wystawiania_faktury_tydzien` varchar(200) COLLATE utf8_unicode_ci DEFAULT '',
  `termin_wystawiania_faktury_dzien` varchar(200) COLLATE utf8_unicode_ci DEFAULT '',
  `domyslny_rachunek_bankowy` int(11) DEFAULT '-1',
  `data_aktywacji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data_rejestracji` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `program_partnerski` tinyint(4) DEFAULT '0',
  `kontakt_opis` text COLLATE utf8_unicode_ci,
  `email_prefix` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `place_prefix` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `logo` varchar(255) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',
  `typ_klienta` varchar(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '0',
  `wewnetrzny_typ` varchar(10) COLLATE utf8_unicode_ci NOT NULL DEFAULT '0',
  `kod` varchar(50) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',
  `czy_koszty` tinyint(4) NOT NULL DEFAULT '0',
  `czy_kontrahenci` tinyint(4) NOT NULL DEFAULT '0',
  `kraj` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `waluta` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `VAT` int(11) NOT NULL DEFAULT '23',
  `jezyk` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `sprzedawca_id` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `uzytkownicy_FI_1` (`parent_user_id`),
  KEY `uzytkownicy_FI_2` (`root_user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7096 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `uzytkownicysystemowi`
--

DROP TABLE IF EXISTS `uzytkownicysystemowi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uzytkownicysystemowi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` varchar(255) DEFAULT NULL,
  `login` varchar(60) DEFAULT NULL,
  `imie` varchar(30) DEFAULT NULL,
  `haslo` varchar(100) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  `data_utworzenia` varchar(20) DEFAULT NULL,
  `data_aktualizacji` varchar(20) DEFAULT NULL,
  `data_ostatniego_logowania` varchar(20) DEFAULT NULL,
  `data_poprzedniego_logowania` varchar(20) DEFAULT NULL,
  `czy_aktywne` tinyint(4) DEFAULT '0',
  `uprawnienia` text,
  `domyslny_widok_po_zalogowaniu` int(11) DEFAULT '0',
  `token` varchar(255) DEFAULT NULL,
  `data_waznosci_tokena` varchar(20) DEFAULT NULL,
  `reset_uid` varchar(255) DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `uzytkownik_haslo_tymczasowe`
--

DROP TABLE IF EXISTS `uzytkownik_haslo_tymczasowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uzytkownik_haslo_tymczasowe` (
  `uzytkownicy_id` int(11) DEFAULT NULL,
  `data` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `index_profilu` int(11) DEFAULT '1',
  `checksum` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  KEY `uzytkownik_haslo_tymczasowe_FI_1` (`uzytkownicy_id`),
  CONSTRAINT `uzytkownik_haslo_tymczasowe_FK_1` FOREIGN KEY (`uzytkownicy_id`) REFERENCES `uzytkownicy` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=594 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `uzytkownik_prawa`
--

DROP TABLE IF EXISTS `uzytkownik_prawa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uzytkownik_prawa` (
  `uzytkownicy_id` int(11) DEFAULT NULL,
  `konfiguracja` text COLLATE utf8_unicode_ci,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  KEY `uzytkownik_prawa_FI_1` (`uzytkownicy_id`),
  CONSTRAINT `uzytkownik_prawa_FK_1` FOREIGN KEY (`uzytkownicy_id`) REFERENCES `uzytkownicy` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7037 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `video_pomoc`
--

DROP TABLE IF EXISTS `video_pomoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `video_pomoc` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `root_user_id` int(11) NOT NULL,
  `nazwa` varchar(255) DEFAULT NULL,
  `opis` text,
  `plik_uuid` varchar(36) DEFAULT NULL,
  `nazwa_pliku` varchar(255) DEFAULT NULL,
  `kolejnosc` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `video_pomoc_I_1` (`plik_uuid`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `wartosci_parametrow`
--

DROP TABLE IF EXISTS `wartosci_parametrow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wartosci_parametrow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_parametr` int(11) NOT NULL,
  `wartosc` varchar(127) COLLATE utf8_unicode_ci NOT NULL,
  `wartosc2` varchar(127) COLLATE utf8_unicode_ci NOT NULL,
  `wartosc3` varchar(127) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `wartosci_parametrow_FI_1` (`id_parametr`),
  CONSTRAINT `wartosci_parametrow_FK_1` FOREIGN KEY (`id_parametr`) REFERENCES `parametry_produktow` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=284 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zamowieniaobsluga`
--

DROP TABLE IF EXISTS `zamowieniaobsluga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zamowieniaobsluga` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `osoba_id` int(11) DEFAULT NULL,
  `status` int(11) NOT NULL DEFAULT '0',
  `zamowienie_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `zamowieniaobsluga_FI_1` (`zamowienie_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zamowienie`
--

DROP TABLE IF EXISTS `zamowienie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zamowienie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numer_referencyjny` varchar(400) DEFAULT '',
  `data` varchar(20) DEFAULT NULL,
  `data_platnosci` varchar(20) DEFAULT NULL,
  `data_wystawienia` varchar(20) DEFAULT '',
  `data_termin_zaplaty` varchar(20) DEFAULT NULL,
  `data_termin_zaplaty_dni` varchar(5) NOT NULL DEFAULT '0',
  `data_ostatniego_przypomnienia` varchar(20) NOT NULL DEFAULT '',
  `forma_platnosci` int(11) NOT NULL DEFAULT '0',
  `forma_platnosci_opis` varchar(60) DEFAULT 'płatność online',
  `kwota_brutto` varchar(100) DEFAULT NULL,
  `przesylka_kwota_brutto` varchar(50) DEFAULT NULL,
  `osoba_prywatna` tinyint(4) NOT NULL DEFAULT '0',
  `wystaw_e_fakture` tinyint(4) NOT NULL DEFAULT '0',
  `z_imie_nazwisko` varchar(120) DEFAULT NULL,
  `z_telefon` varchar(20) DEFAULT NULL,
  `z_email` varchar(60) DEFAULT NULL,
  `w_nazwa_firmy` varchar(255) DEFAULT '',
  `w_imie_nazwisko` varchar(120) DEFAULT NULL,
  `w_adres` varchar(255) DEFAULT NULL,
  `w_kod_pocztowy` varchar(12) DEFAULT NULL,
  `w_miejscowosc` varchar(255) DEFAULT NULL,
  `w_telefon` varchar(20) DEFAULT NULL,
  `w_email` varchar(60) DEFAULT NULL,
  `w_kraj` varchar(6) NOT NULL DEFAULT 'PL',
  `f_nazwa_firmy_lub_osoby` varchar(255) DEFAULT NULL,
  `f_adres` varchar(255) DEFAULT NULL,
  `f_kod_pocztowy` varchar(12) DEFAULT NULL,
  `f_miejscowosc` varchar(255) DEFAULT NULL,
  `f_nip` varchar(20) DEFAULT NULL,
  `status` varchar(20) DEFAULT NULL,
  `uid` varchar(255) DEFAULT NULL,
  `uuid_przestrzeni` int(11) NOT NULL DEFAULT '1',
  `payback` varchar(20) DEFAULT '',
  `sposob_dostawy` int(11) NOT NULL DEFAULT '2',
  `id_paczkomatu` varchar(50) DEFAULT '',
  `uwagi` text,
  `uwagi_klienta` text,
  `uzytkownicy_id` int(11) DEFAULT NULL,
  `pp_name` varchar(30) DEFAULT '',
  `pp_user_id` varchar(100) DEFAULT '',
  `kuponyrabatowe_id` int(11) DEFAULT '0',
  `zamowienie_zewnetrzne` tinyint(4) NOT NULL DEFAULT '0',
  `do_wyjasnienia` tinyint(4) NOT NULL DEFAULT '0',
  `zafakturowac` tinyint(4) NOT NULL DEFAULT '0',
  `wystawiono_prowizje_pp` tinyint(4) DEFAULT '0',
  `zgoda_regulamin` tinyint(4) DEFAULT '0',
  `zgoda_przetwarzaniedanych` tinyint(4) DEFAULT '0',
  `numer_rachunku_bankowego` varchar(100) DEFAULT '',
  `faktura_id` int(11) DEFAULT '0',
  `czy_koszty` tinyint(4) NOT NULL DEFAULT '0',
  `czas_realizacji_start` int(11) NOT NULL,
  `czas_realizacji_koniec` int(11) NOT NULL,
  `czas_realizacji` int(11) NOT NULL DEFAULT '3',
  `czas_zrealizowano` int(11) NOT NULL,
  `waluta` varchar(3) NOT NULL,
  `sprzedawca_id` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `zamowienie_FI_1` (`faktura_id`),
  KEY `zamowienie_I_1` (`uuid_przestrzeni`),
  KEY `data` (`data`)
) ENGINE=InnoDB AUTO_INCREMENT=20746 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zapytaniafirmaplus`
--

DROP TABLE IF EXISTS `zapytaniafirmaplus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zapytaniafirmaplus` (
  `imie_nazwisko` varchar(120) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `liczba_pracownikow` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `liczba_pakietow` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `temat` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `tresc` text COLLATE utf8_unicode_ci,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zapytaniakontakt`
--

DROP TABLE IF EXISTS `zapytaniakontakt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zapytaniakontakt` (
  `imie` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwisko` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `temat` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `tresc` text COLLATE utf8_unicode_ci,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zapytaniaofertowe`
--

DROP TABLE IF EXISTS `zapytaniaofertowe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zapytaniaofertowe` (
  `imie` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwisko` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nazwa_firmy` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `nip` varchar(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` varchar(60) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefon2` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fax` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kolorystyka` varchar(255) COLLATE utf8_unicode_ci DEFAULT '',
  `stanowisko` varchar(80) COLLATE utf8_unicode_ci DEFAULT NULL,
  `przyklady` text COLLATE utf8_unicode_ci,
  `uwagi` text COLLATE utf8_unicode_ci,
  `status` int(11) DEFAULT '0',
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zdania`
--

DROP TABLE IF EXISTS `zdania`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zdania` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tekst` text,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zdania_synonimy`
--

DROP TABLE IF EXISTS `zdania_synonimy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zdania_synonimy` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tekst` text,
  `zdania_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `zdania_synonimy_FI_1` (`zdania_id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin2;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zrodlaodwiedzin`
--

DROP TABLE IF EXISTS `zrodlaodwiedzin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zrodlaodwiedzin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `campaign_source` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `campaign_name` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `campaign_medium` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `campaign_content` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `campaign_term` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `first_visit` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `previous_visit` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `current_visit_started` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `times_visited` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pages_viewed` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `zamowienie_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `zrodlaodwiedzin_FI_1` (`zamowienie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=1579 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-01 20:56:14
