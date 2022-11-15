set identity_insert [Merken] on;

insert into Merken(merkId, naam) values (1, 'BMW');
insert into Merken(merkId, naam) values (2, 'Ferrari');
insert into Merken(merkId, naam) values (3, 'Ford');
insert into Merken(merkId, naam) values (4, 'Nissan');
insert into Merken(merkId, naam) values (5, 'Porsche');

set identity_insert [Merken] off;
set identity_insert [Models] on;

insert into [Models] (modelId, naam, MerkId) values (1, 'i8', 1);
insert into [Models] (modelId, naam, MerkId) values (2, 'M4 Coupe', 1);
insert into [Models] (modelId, naam, MerkId) values (3, '1M Coupe', 1);
insert into [Models] (modelId, naam, MerkId) values (4, '323ti Sport', 1);
insert into [Models] (modelId, naam, MerkId) values (5, 'M3 Forza Edition', 1);
insert into [Models] (modelId, naam, MerkId) values (6, '458 Speciale', 2);
insert into [Models] (modelId, naam, MerkId) values (7, 'Enzo Ferrari', 2);
insert into [Models] (modelId, naam, MerkId) values (8, 'F50', 2);
insert into [Models] (modelId, naam, MerkId) values (9, '512 TR', 2);
insert into [Models] (modelId, naam, MerkId) values (10, '250 GTO', 2);
insert into [Models] (modelId, naam, MerkId) values (11, 'Shelby GT350R', 3);
insert into [Models] (modelId, naam, MerkId) values (12, 'GT', 3);
insert into [Models] (modelId, naam, MerkId) values (13, 'SVT Cobra R', 3);
insert into [Models] (modelId, naam, MerkId) values (14, 'Escord RS Cosworth', 3);
insert into [Models] (modelId, naam, MerkId) values (15, 'Mustang Boss 302', 3);
insert into [Models] (modelId, naam, MerkId) values (16, '#23 Nissan Altima', 4);
insert into [Models] (modelId, naam, MerkId) values (17, 'GT-R Black Edition', 4);
insert into [Models] (modelId, naam, MerkId) values (18, 'Fairlady Z', 4);
insert into [Models] (modelId, naam, MerkId) values (19, 'R34 Skyline V-Spec', 4);
insert into [Models] (modelId, naam, MerkId) values (20, 'Silvia S15', 4);
insert into [Models] (modelId, naam, MerkId) values (21, 'Cayman GT4', 5);
insert into [Models] (modelId, naam, MerkId) values (22, '918 Spyder', 5);
insert into [Models] (modelId, naam, MerkId) values (23, 'Carrera GT', 5);
insert into [Models] (modelId, naam, MerkId) values (24, '911 GT1 Strassenversion', 5);
insert into [Models] (modelId, naam, MerkId) values (25, '906 Carrera 6', 5);

set identity_insert [Models] off;
set identity_insert [Autos] on;

insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (1, 630, 357, 2015, 1, 275000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (2, 554, 431, 2014, 1, 135000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (3, 486, 335, 2011, 1, 64000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (4, 328, 168, 2000, 1, 38000, 600);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (5, 525, 276, 1991, 1, 90000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (6, 786, 597, 2013, 2, 330000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (7, 769, 650, 2002, 2, 12000000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (8, 703, 513, 1995, 2, 700000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (9, 535, 421, 1992, 2, 430000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (10, 528, 300, 1962, 2, 1350000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (11, 643, 526, 2016, 3, 120000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (12, 640, 550, 2005, 3, 600000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (13, 434, 300, 1995, 3, 81000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (14, 431, 224, 1992, 3, 55000, 600);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (15, 342, 290, 1969, 3, 70000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (16, 785, 668, 2017, 4, 200000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (17, 702, 542, 2012, 4, 220000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (18, 443, 287, 2003, 4, 52000, 600);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (19, 537, 276, 2002, 4, 210000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (20, 405, 250, 2000, 4, 39500, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (21, 673, 385, 2016, 5, 140000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (22, 858, 887, 2014, 5, 1150000, 900);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (23, 750, 605, 2003, 5, 1050000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (24, 776, 536, 1998, 5, 1250000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, merkId, kostprijs, totalePI) values (25, 640, 210, 1966, 5, 900000, 800);

set identity_insert [Autos] off;
set identity_insert [Klasses] on;

insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (1, 'E', 0, 300);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (2, 'D', 301, 400);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (3, 'C', 401, 500);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (4, 'B', 501, 600);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (5, 'A', 601, 700);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (6, 'S', 701, 800);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (7, 'R', 801, 900);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (8, 'P', 901, 990);
insert into Forza.dbo.[Klasses](KlasseId, naam, minPI, maxPI) values (9, 'X', 991, 999);

set identity_insert Klasses off;
set identity_insert OverMijs on;

insert into OverMijs(OverMijId, titelPersInfo, tekstPersInfo, titelAppInfo, tekstAppInfo, afbeelding1, afbeelding2) values (1, 'Dennis Pynaerts', 'Hey, ik ben Dennis Pynaerts, welkom op mijn website! Deze website heb ik gemaakt als student bij de hogeschool Thomas More te Turnhout waar ik een opleiding graduaat Programmeren volg. Ik ben 33 jaar oud, woonachtig te Ravels en ik heb Forza Motorsport als onderwerp gekozen omdat ik Forza al meer dan 15 jaar speel, ik denk dat ik mezelf gerust een veteraan mag noemen. Hieronder volgt een beetje meer uitleg over de website.', 'Forza Motorsport 7', 'Forza Motorsport 7 is een racing game met karakteristieken van een simulatie racer met een goede blend van arcade. Een van de vele kenmerken van dit spel is dat het je in staat stelt om zelf auto''s samen te stellen en daarna af te stellen naar het circuit van je voorkeur. Of je stelt ze af om allround te gebruiken als je verkiest om voornamelijk online in publieke lobbies te racen. Het spel zelf is ondertussen al meer dan 5 jaar oud en volgend jaar komt de opvolger uit met hopelijk nog meer auto''s om te bouwen en circuits op te racen. Als je naar de leaderboard pagina gaat, kan je browsen door de rondetijden van onze gebruikers en als je zelf een account hebt, zelf een rondetijd registreren. Enjoy! ', 'C:\TM\2\Webapplicaties\Project\images\R34RioStoplight.jpg', 'C:\TM\2\Webapplicaties\Project\images\R34WetNurbGP.jpg');

set identity_insert OverMijs off;
set identity_insert AspNetusers on;

insert into AspNetUsers(Id, GebruikerId, nickname, emailadres, isAdmin, overMijId, AccessFailedCount) values ('1', 1, 'LeRacer', 'r0901534@student.thomasmore.be', 1, 1, 0);
insert into AspNetUsers(Id, GebruikerId, nickname, emailadres, isAdmin, AccessFailedCount) values ('2', 2, 'Player One', 'player_one@student.thomasmore.be', 0, 0);
insert into AspNetUsers(Id, GebruikerId, nickname, emailadres, isAdmin, AccessFailedCount) values ('3', 3, 'New Player', 'new_player@student.thomasmore.be', 0, 0);

set identity_insert Forza.dbo.AspNetusers off;
set identity_insert Forza.dbo.GebruikerAutos on;

insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (1, 1, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (2, 2, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (3, 3, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (4, 4, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (5, 5, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (6, 6, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (7, 7, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (8, 8, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (9, 9, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (10 ,10, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (11 ,11, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (12, 12, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (13, 13, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (14 ,14, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (15 ,15, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (16, 16, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (17, 17, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (18, 18, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (19, 19, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (20, 20, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (21, 21, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (22, 22, 1);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (23, 23, 2);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (24, 24, 3);
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (25, 25, 1);

set identity_insert GebruikerAutos off;
set identity_insert AutoKlasses on;

insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (1, 1, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (2, 1, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (3, 1, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (4, 1, 4);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (5, 1, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (6, 1, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (7, 1, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (8,1, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (9, 1, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (10, 2, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (11, 2, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (12, 2, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (13, 2, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (14, 2, 4);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (15, 2, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (16, 2, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (17, 2, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (18, 3, 4);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (19, 3, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (20, 3, 5);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (21, 3, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (22, 3, 7);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (23, 3, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (24, 3, 6);
insert into Forza.dbo.AutoKlasses(AutoKlasseId, gebruikerAutoId, klasseId) values (25, 3, 6);

set identity_insert AutoKlasses off;
set identity_insert Circuits on;

insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (1, 'COTA', 'C:\TM\2\Webapplicaties\Project\images\COTA.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (2, 'Daytona', 'C:\TM\2\Webapplicaties\Project\images\Daytona.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (3, 'Hockenheim', 'C:\TM\2\Webapplicaties\Project\images\Hockenheim.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (4, 'Laguna Seca', 'C:\TM\2\Webapplicaties\Project\images\Laguna Seca.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (5, 'Mugello', 'C:\TM\2\Webapplicaties\Project\images\Mugello.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (6, 'Road Atlanta', 'C:\TM\2\Webapplicaties\Project\images\RoadAtlanta.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (7, 'Sebring', 'C:\TM\2\Webapplicaties\Project\images\Sebring.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (8, 'Sonoma', 'C:\TM\2\Webapplicaties\Project\images\Sonoma.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, afbeelding) values (9, 'Watkins Glen', 'C:\TM\2\Webapplicaties\Project\images\WatkinsGlen.jpg');

set identity_insert Circuits off;
set identity_insert Laptimes on;

insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (1, 1, 1, DATEFROMPARTS('2021', '05', '02'), '02.09.500');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (2, 5, 2, DATEFROMPARTS('2022', '04', '12'), '02.09.137');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (3, 8, 1, DATEFROMPARTS('2020', '05', '07'), '02.09.432');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (4, 10, 3, DATEFROMPARTS('2021', '05', '13'), '02.09.580');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (5, 14, 5, DATEFROMPARTS('2022', '11', '06'), '02.09.501');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (6, 13, 4, DATEFROMPARTS('2019', '08', '08'), '02.09.687');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (7, 15, 4, DATEFROMPARTS('2020', '03', '18'), '02.09.980');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (8, 18, 6, DATEFROMPARTS('2021', '04', '07'), '02.09.624');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (9, 12, 7, DATEFROMPARTS('2022', '01', '21'), '02.09.325');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (10, 20, 8, DATEFROMPARTS('2021', '10', '28'), '02.09.789');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (11, 21, 9, DATEFROMPARTS('2020', '12', '13'), '02.09.846');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (12, 22, 2, DATEFROMPARTS('2018', '05', '22'), '02.09.789');
insert into Forza.dbo.Laptimes(LaptimeId, autoKlasseId, circuitId, datum, rondetijd) values (13, 23, 3, DATEFROMPARTS('2017', '06', '14'), '02.09.123');

set identity_insert Laptimes off;