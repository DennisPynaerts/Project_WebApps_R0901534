USE [Forza]
GO

set identity insert Forza.[Model] on

insert into [Forza].[Model](naam) 
values 
('i8'),
('M4 Coupe'),
('1M Coupe'),
('323ti Sport'),
('M3 Forza Edition'),
('458 Speciale'),
('Enzo Ferrari'),
('F50'),
('512 TR'),
('250 GTO'),
('Shelby GT350R'),
('GT'),
('SVT Cobra R'),
('Escord RS Cosworth'),
('Mustang Boss 302'),
('#23 Nissan Altima'),
('GT-R Black Edition'),
('Fairlady Z'),
('R34 Skyline V-Spec'),
('Silvia S15'),
('Cayman GT4'),
('918 Spyder'),
('Carrera GT'),
('911 GT1 Strassenversion'),
('906 Carrera 6');

set identity insert Forza.[Model] off
set identity insert Forza.[Merk] on

insert into [Forza].Merk(naam, modelId) 
values
('BMW', 1),
('BMW', 2),
('BMW', 3),
('BMW', 4),
('BMW', 5),
('Ferrari', 6),
('Ferrari', 7),
('Ferrari', 8),
('Ferrari', 9),
('Ferrari', 10),
('Ford', 11),
('Ford', 12),
('Ford', 13),
('Ford', 14),
('Ford', 15),
('Nissan', 16),
('Nissan', 17),
('Nissan', 18),
('Nissan', 19),
('Nissan', 20),
('Porsche', 21),
('Porsche', 22),
('Porsche', 23),
('Porsche', 24),
('Porsche', 25);

set identity insert Forza.[Merk] off
set identity insert Forza.[Auto] on

insert into [Forza].[Auto](basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) 
values 
(630, 357, 2015, 1, 275000, 800),
(554, 431, 2014, 1, 135000, 700),
(486, 335, 2011, 1, 64000, 700),
(328, 168, 2000, 1, 38000, 600),
(525, 276, 1991, 1, 90000, 700),
(786, 597, 2013, 2, 330000, 800),
(769, 650, 2002, 2, 12000000, 800),
(703, 513, 1995, 2, 700000, 800),
(535, 421, 1992, 2, 430000, 800),
(528, 300, 1962, 2, 1350000, 700),
(643, 526, 2016, 3, 120000, 800),
(640, 550, 2005, 3, 600000, 800),
(434, 300, 1995, 3, 81000, 700),
(431, 224, 1992, 3, 55000, 600),
(342, 290, 1969, 3, 70000, 700),
(785, 668, 2017, 4, 200000, 800),
(702, 542, 2012, 4, 220000, 800),
(443, 287, 2003, 4, 52000, 600),
(537, 276, 2002, 4, 210000, 800),
(405, 250, 2000, 4, 39500, 700),
(673, 385, 2016, 5, 140000, 800),
(858, 887, 2014, 5, 1150000, 900),
(750, 605, 2003, 5, 1050000, 800),
(776, 536, 1998, 5, 1250000, 800),
(640, 210, 1966, 5, 900000, 800);


set identity insert Forza.[Auto] off
set identity insert Forza.[Klasse] on

insert into Forza.[Klasse](naam, maxPI, minPI)
values 
('E', 0, 300),
('D', 301, 400),
('C', 401, 500),
('B', 501, 600),
('A', 601, 700),
('S', 701, 800),
('R', 801, 900),
('P', 901, 990),
('P', 991, 999);

set identity insert Forza.Klasse off
set identity insert Forza.OverMij on

insert into Forza.OverMij(titelPersInfo, tekstPersInfo, titelAppInfo, tekstAppInfo, afbeelding1, afbeelding2)
values
('Dennis Pynaerts', 'Hey, ik ben Dennis Pynaerts, welkom op mijn website! Deze website heb ik gemaakt als student bij de hogeschool Thomas More te Turnhout waar ik een opleiding graduaat Programmeren volg. Ik ben 33 jaar oud, woonachtig te Ravels en ik heb Forza Motorsport als onderwerp gekozen omdat ik Forza al meer dan 15 jaar speel, ik denk dat ik mezelf gerust een veteraan mag noemen. Hieronder volgt een beetje meer uitleg over de website.', 'Forza Motorsport 7', 'Forza Motorsport 7 is een racing game met karakteristieken van een simulatie racer met een goede blend van arcade. Een van de vele kenmerken van dit spel is dat het je in staat stelt om zelf auto''s samen te stellen en daarna af te stellen naar het circuit van je voorkeur. Of je stelt ze af om allround te gebruiken als je verkiest om voornamelijk online in publieke lobbies te racen. Het spel zelf is ondertussen al meer dan 5 jaar oud en volgend jaar komt de opvolger uit met hopelijk nog meer auto''s om te bouwen en circuits op te racen. Als je naar de leaderboard pagina gaat, kan je browsen door de rondetijden van onze gebruikers en als je zelf een account hebt, zelf een rondetijd registreren. Enjoy! ', 'C:\TM\2\Webapplicaties\Project\images\R34RioStoplight.jpg', 'C:\TM\2\Webapplicaties\Project\images\R34WetNurbGP.jpg');

set identity insert Forza.OverMij off
set identity insert Forza.Gebruiker on

insert into Forza.Gebruiker(nickname, emailadres, isAdmin, wachtwoord, overMijId)
values 
('LeRacer', 'r0901534@student.thomasmore.be', 1, 'abc123', 1),
('Player One', 'player_one@student.thomasmore.be', 0, 'abc123'),
('New Player', 'new_player@student.thomasmore.be', 0, 'abc123');

set identity insert Forza.Gebruiker off
set identity insert Forza.GebruikerAuto on

insert into Forza.GebruikerAuto(autoId, gebruikerId)
values
(1, 1),
(2, 2),
(3, 3),
(4, 1),
(5, 2),
(6, 3),
(7, 1),
(8, 2),
(9, 3),
(10, 1),
(11, 2),
(12, 3),
(13, 1),
(14, 2),
(15, 3),
(16, 1),
(17, 2),
(18, 3),
(19, 1),
(20, 2),
(21, 3),
(22, 1),
(23, 2),
(24, 3),
(25, 1);

set identity insert Forza.GebruikerAuto off
set identity insert Forza.AutoKlasse on

insert into Forza.AutoKlasse(gebruikerAutoId, klasseId)
values
(1, 6),
(2, 5),
(3, 5),
(4, 4),
(5, 5),
(6, 6),
(7, 6),
(8, 6),
(9, 6),
(10, 5),
(11, 6),
(12, 6),
(13, 5),
(14, 4),
(15, 5),
(16, 6),
(17, 6),
(18, 4),
(19, 6),
(20, 5),
(21, 6),
(22, 7),
(23, 6),
(24, 6),
(25, 6);

set identity insert Forza.AutoKlasse off
set identity insert Forza.Circuit on

insert into Forza.Circuit(naam, afbeelding)
values
('COTA', 'C:\TM\2\Webapplicaties\Project\images\COTA.jpg'),
('Daytona', 'C:\TM\2\Webapplicaties\Project\images\Daytona.jpg'),
('Hockenheim', 'C:\TM\2\Webapplicaties\Project\images\Hockenheim.jpg'),
('Laguna Seca', 'C:\TM\2\Webapplicaties\Project\images\Laguna Seca.jpg'),
('Mugello', 'C:\TM\2\Webapplicaties\Project\images\Mugello.jpg'),
('Road Atlanta', 'C:\TM\2\Webapplicaties\Project\images\RoadAtlanta.jpg'),
('Sebring', 'C:\TM\2\Webapplicaties\Project\images\Sebring.jpg'),
('Sonoma', 'C:\TM\2\Webapplicaties\Project\images\Sonoma.jpg'),
('Watkins Glen', 'C:\TM\2\Webapplicaties\Project\images\WatkinsGlen.jpg');

set identity insert Forza.Circuit off
set identity insert Forza.Laptime on

insert into Forza.Laptime(autoKlasseId, circuitId, datum, rondetijd)
values
(1, 1, DATEFROMPARTS('2021', '05', '02'), '02.09.500'),
(5, 2, DATEFROMPARTS('2022', '04', '12'), '01.48.325'),
(8, 1, DATEFROMPARTS('2020', '05', '07'), '02.07.302'),
(10, 3, DATEFROMPARTS('2021', '05', '13'), '02.09.500'),
(14, 5, DATEFROMPARTS('2022', '11', '06'), '02.09.500'),
(13, 4, DATEFROMPARTS('2019', '08', '08'), '02.09.500'),
(15, 4, DATEFROMPARTS('2020', '03', '18'), '02.09.500'),
(18, 6, DATEFROMPARTS('2021', '04', '07'), '02.09.500'),
(12, 7, DATEFROMPARTS('2022', '01', '21'), '02.09.500'),
(20, 8, DATEFROMPARTS('2021', '10', '28'), '02.09.500'),
(21, 9, DATEFROMPARTS('2020', '12', '13'), '02.09.500'),
(22, 2, DATEFROMPARTS('2018', '05', '22'), '02.09.500'),
(23, 3, DATEFROMPARTS('2017', '06', '14'), '02.09.500');