set identity_insert [Merken] on;

insert into Merken(merkId, naam) values (1, 'BMW');
insert into Merken(merkId, naam) values (2, 'Ferrari');
insert into Merken(merkId, naam) values (3, 'Ford');
insert into Merken(merkId, naam) values (4, 'Nissan');
insert into Merken(merkId, naam) values (5, 'Porsche');

set identity_insert [Merken] off;
set identity_insert [Models] on;

insert into [Models] (ModelId, naam, MerkId) values (1, 'i8', 1);
insert into [Models] (ModelId, naam, MerkId) values (2, 'M4 Coupe', 1);
insert into [Models] (ModelId, naam, MerkId) values (3, '1M Coupe', 1);
insert into [Models] (ModelId, naam, MerkId) values (4, '323ti Sport', 1);
insert into [Models] (ModelId, naam, MerkId) values (5, 'M3 Forza Edition', 1);
insert into [Models] (ModelId, naam, MerkId) values (6, '458 Speciale', 2);
insert into [Models] (ModelId, naam, MerkId) values (7, 'Enzo Ferrari', 2);
insert into [Models] (ModelId, naam, MerkId) values (8, 'F50', 2);
insert into [Models] (ModelId, naam, MerkId) values (9, '512 TR', 2);
insert into [Models] (ModelId, naam, MerkId) values (10, '250 GTO', 2);
insert into [Models] (ModelId, naam, MerkId) values (11, 'Shelby GT350R', 3);
insert into [Models] (ModelId, naam, MerkId) values (12, 'GT', 3);
insert into [Models] (ModelId, naam, MerkId) values (13, 'SVT Cobra R', 3);
insert into [Models] (ModelId, naam, MerkId) values (14, 'Escord RS Cosworth', 3);
insert into [Models] (ModelId, naam, MerkId) values (15, 'Mustang Boss 302', 3);
insert into [Models] (ModelId, naam, MerkId) values (16, '#23 Nissan Altima', 4);
insert into [Models] (ModelId, naam, MerkId) values (17, 'GT-R Black Edition', 4);
insert into [Models] (ModelId, naam, MerkId) values (18, 'Fairlady Z', 4);
insert into [Models] (ModelId, naam, MerkId) values (19, 'R34 Skyline V-Spec', 4);
insert into [Models] (ModelId, naam, MerkId) values (20, 'Silvia S15', 4);
insert into [Models] (ModelId, naam, MerkId) values (21, 'Cayman GT4', 5);
insert into [Models] (ModelId, naam, MerkId) values (22, '918 Spyder', 5);
insert into [Models] (ModelId, naam, MerkId) values (23, 'Carrera GT', 5);
insert into [Models] (ModelId, naam, MerkId) values (24, '911 GT1 Strassenversion', 5);
insert into [Models] (ModelId, naam, MerkId) values (25, '906 Carrera 6', 5);

set identity_insert [Models] off;
set identity_insert [Autos] on;

insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (1, 630, 357, 2015, 1, 275000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (2, 554, 431, 2014, 2, 135000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (3, 486, 335, 2011, 3, 64000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (4, 328, 168, 2000, 4, 38000, 600);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (5, 525, 276, 1991, 5, 90000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (6, 786, 597, 2013, 6, 330000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (7, 769, 650, 2002, 7, 12000000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (8, 703, 513, 1995, 8, 700000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (9, 535, 421, 1992, 9, 430000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (10, 528, 300, 1962, 10, 1350000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (11, 643, 526, 2016, 11, 120000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (12, 640, 550, 2005, 12, 600000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (13, 434, 300, 1995, 13, 81000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (14, 431, 224, 1992, 14, 55000, 600);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (15, 342, 290, 1969, 15, 70000, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (16, 785, 668, 2017, 16, 200000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (17, 702, 542, 2012, 17, 220000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (18, 443, 287, 2003, 18, 52000, 600);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (19, 537, 276, 2002, 19, 210000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (20, 405, 250, 2000, 20, 39500, 700);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (21, 673, 385, 2016, 21, 140000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (22, 858, 887, 2014, 22, 1150000, 900);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (23, 750, 605, 2003, 23, 1050000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (24, 776, 536, 1998, 24, 1250000, 800);
insert into [Autos](AutoId, basisPI, pk, bouwjaar, modelId, kostprijs, totalePI) values (25, 640, 210, 1966, 25, 900000, 800);

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
--set identity_insert AspNetusers on;

--insert into AspNetUsers(Id, nickname, emailadres, isAdmin, overMijId, AccessFailedCount, wachtwoord, PasswordHash) values ('1', 'LeRacer', 'r0901534@student.thomasmore.be', 1, 1, 0, '!Abc123', 'AQAAAAEAACcQAAAAELMzgLsR1gvKxNdrriPX1V1XRlovfDT6DLpjdRP431/qScAMlWVyfqriB60e7OePxw==');
--insert into AspNetUsers(Id, nickname, emailadres, isAdmin, AccessFailedCount, wachtwoord, PasswordHash) values ('2', 'Player One', 'player_one@student.thomasmore.be', 0, 0, '!Abc123', 'AQAAAAEAACcQAAAAELMzgLsR1gvKxNdrriPX1V1XRlovfDT6DLpjdRP431/qScAMlWVyfqriB60e7OePxw==');
--insert into AspNetUsers(Id, nickname, emailadres, isAdmin, AccessFailedCount, wachtwoord, PasswordHash) values ('3', 'New Player', 'new_player@student.thomasmore.be', 0, 0, '!Abc123', 'AQAAAAEAACcQAAAAELMzgLsR1gvKxNdrriPX1V1XRlovfDT6DLpjdRP431/qScAMlWVyfqriB60e7OePxw==');

--set identity_insert Forza.dbo.AspNetusers off;
set identity_insert Forza.dbo.GebruikerAutos on;

insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (1, 1, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (2, 2, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (3, 3, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (4, 4, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (5, 5, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (6, 6, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (7, 7, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (8, 8, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (9, 9, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (10 ,10, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (11 ,11, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (12, 12, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (13, 13, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (14 ,14, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (15 ,15, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (16, 16, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (17, 17, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (18, 18, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (19, 19, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (20, 20, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (21, 21, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (22, 22, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (23, 23, '59f9d6c5-5c3e-4f00-802b-8625612528e2');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (24, 24, 'c7bede4c-c966-4025-b1ca-1673376153a5');
insert into GebruikerAutos(GebruikerAutoId, autoId, gebruikerId) values (25, 25, '00ea1a74-dc1d-4e6d-a26e-a2462fc271f2');

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

insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (1, 'COTA', 'COTA.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (2, 'Daytona', 'Daytona.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (3, 'Hockenheim', 'Hockenheim.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (4, 'Laguna Seca', 'Laguna Seca.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (5, 'Mugello', 'Mugello.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (6, 'Road Atlanta', 'Road Atlanta.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (7, 'Sebring', 'Sebring.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (8, 'Sonoma', 'Sonoma.jpg');
insert into Forza.dbo.Circuits(CircuitId, naam, Afbeelding) values (9, 'Watkins Glen', 'Watkins Glen.jpg');

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