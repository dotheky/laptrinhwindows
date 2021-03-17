create database Module2
go

use Module2
go

create table Roles(
	ID int primary key(ID) not null identity(1,1),
	Title nvarchar(20) not null
)
go

create table Countries(
	ID int primary key(ID) not null identity(1,1),
	Name nvarchar(20) not null
)
go

create table Offices(
	ID int primary key(ID) not null identity(1,1),
	CountryID int not null foreign key (CountryID) references Countries (ID),
	Title nvarchar(20) not null,
	Phone varchar(15),
	Contact nvarchar(150)
)
go

create table Users(
	ID int primary key(ID) not null identity(1,1),
	OfficeID int not null foreign key (OfficeID) references Offices (ID),
	RoleID int not null foreign key (RoleID) references Roles (ID),
	Email nvarchar(150) not null unique,
	Password varchar(150) not null,
	Firstname nvarchar(30) not null,
	Lastname nvarchar(30) not null,
	Birthdate date not null,
	Active bit not null
)
go

create table Aircrafts(
	ID int primary key(ID) not null identity(1,1),
	Name nvarchar(20) not null,
	MakeModel nvarchar(20),
	TotalSeats int not null,
	EconomySeats int not null,
	BusinessSeats int not null
)
go

create table Airports(
	ID int primary key(ID) not null identity(1,1),
	CountryID int not null foreign key (CountryID) references Countries (ID),
	IATACode nvarchar(20) not null,
	Name nvarchar(30) not null
)
go

create table Routes(
	ID int primary key(ID) not null identity(1,1),
	DepartureAirportID int not null foreign key (DepartureAirportID) references Airports (ID),
	ArrivalAirportID int not null foreign key (ArrivalAirportID) references Airports (ID),
	Distance int not null,
	FlightTime datetime not null 
)
go
select * from Aircrafts
select * from Routes
select * from Airports
select * from Schedules
create table Schedules(
	ID int primary key(ID) not null identity(1,1),
	Date date,
	Time time,
	AircraftID int not null foreign key(AircraftID) references Aircrafts (ID),
	RouteID int not null foreign key(RouteID) references Routes (ID),
	FlightNumber nvarchar(10) not null,
	EconomyPrice money not null,
	Confirmed bit not null
)
go
SET IDENTITY_INSERT [dbo].[Aircrafts] ON 
INSERT [dbo].[Aircrafts] ([ID], [Name], [MakeModel], [TotalSeats], [EconomySeats], [BusinessSeats]) VALUES (1, N'Boeing 738', N'B738-1950', 176, 162, 12)
INSERT [dbo].[Aircrafts] ([ID], [Name], [MakeModel], [TotalSeats], [EconomySeats], [BusinessSeats]) VALUES (2, N'Boeing 739', N'B739-1954', 169, 96, 51)
SET IDENTITY_INSERT [dbo].[Aircrafts] OFF 
select *from Aircrafts
go

SET IDENTITY_INSERT [dbo].[Airports] ON
INSERT [dbo].[Airports] ([ID], [CountryID], [IATACode], [Name]) VALUES (2, 185, N'AUH', N'Abu Dhabi')
INSERT [dbo].[Airports] ([ID], [CountryID], [IATACode], [Name]) VALUES (3, 52, N'CAI', N'Cairo')
INSERT [dbo].[Airports] ([ID], [CountryID], [IATACode], [Name]) VALUES (4, 13, N'BAH', N'Bahrain')
INSERT [dbo].[Airports] ([ID], [CountryID], [IATACode], [Name]) VALUES (5, 194, N'ADE', N'Aden')
INSERT [dbo].[Airports] ([ID], [CountryID], [IATACode], [Name]) VALUES (6, 142, N'DOH', N'Doha')
INSERT [dbo].[Airports] ([ID], [CountryID], [IATACode], [Name]) VALUES (7, 152, N'RUH', N'Riyadh')
SET IDENTITY_INSERT [dbo].[Airports] OFF
select *from Airports
go

SET IDENTITY_INSERT [dbo].[Countries]  ON 
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (1, N'Afghanistan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (2, N'Albania')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (3, N'Algeria')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (4, N'Andorra')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (5, N'Angola')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (6, N'Antigua & Deps')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (7, N'Argentina')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (8, N'Armenia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (9, N'Australia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (10, N'Austria')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (11, N'Azerbaijan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (12, N'Bahamas')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (13, N'Bahrain')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (14, N'Bangladesh')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (15, N'Barbados')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (16, N'Belarus')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (17, N'Belgium')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (18, N'Belize')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (19, N'Benin')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (20, N'Bhutan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (21, N'Bolivia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (22, N'Bosnia Herzegovina')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (23, N'Botswana')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (24, N'Brazil')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (25, N'Brunei')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (26, N'Bulgaria')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (27, N'Burkina')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (28, N'Burundi')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (29, N'Cambodia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (30, N'Cameroon')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (31, N'Canada')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (32, N'Cape Verde')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (33, N'Central African Rep')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (34, N'Chad')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (35, N'Chile')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (36, N'China')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (37, N'Colombia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (38, N'Comoros')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (39, N'Congo')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (40, N'Congo {Democratic Rep}')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (41, N'Costa Rica')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (42, N'Croatia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (43, N'Cuba')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (44, N'Cyprus')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (45, N'Czech Republic')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (46, N'Denmark')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (47, N'Djibouti')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (48, N'Dominica')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (49, N'Dominican Republic')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (50, N'East Timor')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (51, N'Ecuador')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (52, N'Egypt')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (53, N'El Salvador')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (54, N'Equatorial Guinea')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (55, N'Eritrea')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (56, N'Estonia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (57, N'Ethiopia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (58, N'Fiji')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (59, N'Finland')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (60, N'France')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (61, N'Gabon')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (62, N'Gambia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (63, N'Georgia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (64, N'Germany')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (65, N'Ghana')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (66, N'Greece')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (67, N'Grenada')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (68, N'Guatemala')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (69, N'Guinea')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (70, N'Guinea-Bissau')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (71, N'Guyana')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (72, N'Haiti')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (73, N'Honduras')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (74, N'Hungary')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (75, N'Iceland')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (76, N'India')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (77, N'Indonesia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (78, N'Iran')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (79, N'Iraq')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (80, N'Ireland {Republic}')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (81, N'Israel')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (82, N'Italy')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (83, N'Ivory Coast')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (84, N'Jamaica')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (85, N'Japan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (86, N'Jordan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (87, N'Kazakhstan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (88, N'Kenya')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (89, N'Kiribati')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (90, N'Korea North')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (91, N'Korea South')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (92, N'Kosovo')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (93, N'Kuwait')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (94, N'Kyrgyzstan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (95, N'Laos')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (96, N'Latvia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (97, N'Lebanon')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (98, N'Lesotho')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (99, N'Liberia')
GO
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (100, N'Libya')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (101, N'Liechtenstein')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (102, N'Lithuania')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (103, N'Luxembourg')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (104, N'Macedonia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (105, N'Madagascar')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (106, N'Malawi')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (107, N'Malaysia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (108, N'Maldives')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (109, N'Mali')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (110, N'Malta')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (111, N'Marshall Islands')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (112, N'Mauritania')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (113, N'Mauritius')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (114, N'Mexico')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (115, N'Micronesia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (116, N'Moldova')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (117, N'Monaco')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (118, N'Mongolia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (119, N'Montenegro')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (120, N'Morocco')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (121, N'Mozambique')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (122, N'Myanmar, {Burma}')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (123, N'Namibia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (124, N'Nauru')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (125, N'Nepal')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (126, N'Netherlands')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (127, N'New Zealand')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (128, N'Nicaragua')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (129, N'Niger')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (130, N'Nigeria')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (131, N'Norway')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (132, N'Oman')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (133, N'Pakistan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (134, N'Palau')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (135, N'Panama')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (136, N'Papua New Guinea')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (137, N'Paraguay')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (138, N'Peru')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (139, N'Philippines')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (140, N'Poland')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (141, N'Portugal')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (142, N'Qatar')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (143, N'Romania')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (144, N'Russian Federation')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (145, N'Rwanda')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (146, N'St Kitts & Nevis')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (147, N'St Lucia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (148, N'Saint Vincent & the Grenadines')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (149, N'Samoa')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (150, N'San Marino')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (151, N'Sao Tome & Principe')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (152, N'Saudi Arabia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (153, N'Senegal')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (154, N'Serbia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (155, N'Seychelles')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (156, N'Sierra Leone')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (157, N'Singapore')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (158, N'Slovakia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (159, N'Slovenia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (160, N'Solomon Islands')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (161, N'Somalia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (162, N'South Africa')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (163, N'South Sudan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (164, N'Spain')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (165, N'Sri Lanka')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (166, N'Sudan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (167, N'Suriname')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (168, N'Swaziland')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (169, N'Sweden')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (170, N'Switzerland')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (171, N'Syria')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (172, N'Taiwan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (173, N'Tajikistan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (174, N'Tanzania')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (175, N'Thailand')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (176, N'Togo')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (177, N'Tonga')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (178, N'Trinidad & Tobago')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (179, N'Tunisia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (180, N'Turkey')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (181, N'Turkmenistan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (182, N'Tuvalu')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (183, N'Uganda')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (184, N'Ukraine')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (185, N'United Arab Emirates')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (186, N'United Kingdom')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (187, N'United States')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (188, N'Uruguay')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (189, N'Uzbekistan')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (190, N'Vanuatu')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (191, N'Vatican City')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (192, N'Venezuela')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (193, N'Vietnam')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (194, N'Yemen')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (195, N'Zambia')
INSERT [dbo].[Countries] ([ID], [Name]) VALUES (196, N'Zimbabwe')
SET IDENTITY_INSERT [dbo].[Countries]  OFF
select *from Countries
go

SET IDENTITY_INSERT  [dbo].[Offices] ON
INSERT [dbo].[Offices] ([ID], [CountryID], [Title], [Phone], [Contact]) VALUES (1, 185, N'Abu dhabi', N'638-757-8582', N'MIchael Malki')
INSERT [dbo].[Offices] ([ID], [CountryID], [Title], [Phone], [Contact]) VALUES (3, 52, N'Cairo', N'252-224-8525', N'David Johns')
INSERT [dbo].[Offices] ([ID], [CountryID], [Title], [Phone], [Contact]) VALUES (4, 13, N'Bahrain', N'542-227-5825', N'Katie Ballmer')
INSERT [dbo].[Offices] ([ID], [CountryID], [Title], [Phone], [Contact]) VALUES (5, 142, N'Doha', N'758-278-9597', N'Ariel Levy')
INSERT [dbo].[Offices] ([ID], [CountryID], [Title], [Phone], [Contact]) VALUES (6, 152, N'Riyadh', N'285-285-1474', N'Andrew Hobart')
SET IDENTITY_INSERT [dbo].[Offices] OFF
select *from Offices
go

SET IDENTITY_INSERT [dbo].[Roles] ON
INSERT [dbo].[Roles] ([ID], [Title]) VALUES (1, N'Administrator')
INSERT [dbo].[Roles] ([ID], [Title]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[Roles] OFF
go

SET IDENTITY_INSERT [dbo].[Routes] ON 

INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (1, 2, 4, 453, 64)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (2, 4, 2, 455, 69)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (3, 2, 5, 1636, 152)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (5, 5, 2, 1632, 150)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (6, 2, 7, 807, 90)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (7, 7, 2, 810, 89)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (8, 2, 6, 325, 54)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (9, 6, 2, 325, 54)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (10, 6, 3, 2057, 183)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (11, 3, 6, 2050, 177)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (12, 2, 3, 2381, 264)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (13, 3, 2, 2385, 274)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (14, 2, 3, 2381, 208)
INSERT [dbo].[Routes] ([ID], [DepartureAirportID], [ArrivalAirportID], [Distance], [FlightTime]) VALUES (15, 3, 2, 2381, 211)
SET IDENTITY_INSERT [dbo].[Routes] OFF
select *from Routes
go

SET IDENTITY_INSERT [dbo].[Schedules] ON 
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (1, CAST(N'2018-10-04' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 620.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (2, CAST(N'2018-10-04' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 590.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (3, CAST(N'2018-10-05' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 448.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (4, CAST(N'2018-10-05' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 500.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (5, CAST(N'2018-10-06' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 697.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (6, CAST(N'2018-10-06' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 504.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (7, CAST(N'2018-10-07' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 449.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (8, CAST(N'2018-10-07' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 405.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (9, CAST(N'2018-10-08' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 494.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (10, CAST(N'2018-10-08' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 429.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (11, CAST(N'2018-10-09' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 627.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (12, CAST(N'2018-10-09' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 545.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (13, CAST(N'2018-10-10' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 637.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (14, CAST(N'2018-10-10' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 489.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (15, CAST(N'2018-10-11' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 421.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (16, CAST(N'2018-10-11' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 476.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (17, CAST(N'2018-10-12' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 484.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (18, CAST(N'2018-10-12' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 440.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (19, CAST(N'2018-10-13' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 464.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (20, CAST(N'2018-10-13' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 661.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (21, CAST(N'2018-10-14' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 437.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (22, CAST(N'2018-10-14' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 493.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (23, CAST(N'2018-10-15' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 699.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (24, CAST(N'2018-10-15' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 608.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (25, CAST(N'2018-10-16' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 417.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (26, CAST(N'2018-10-16' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 577.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (27, CAST(N'2018-10-17' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 458.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (28, CAST(N'2018-10-17' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 429.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (29, CAST(N'2018-10-18' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 686.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (30, CAST(N'2018-10-18' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 692.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (31, CAST(N'2018-10-19' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 482.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (32, CAST(N'2018-10-19' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 612.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (33, CAST(N'2018-10-20' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 620.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (34, CAST(N'2018-10-20' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 432.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (35, CAST(N'2018-10-21' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 480.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (36, CAST(N'2018-10-21' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 582.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (37, CAST(N'2018-10-22' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 453.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (38, CAST(N'2018-10-22' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 537.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (39, CAST(N'2018-10-23' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 537.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (40, CAST(N'2018-10-23' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 578.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (41, CAST(N'2018-10-24' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 571.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (42, CAST(N'2018-10-24' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 532.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (43, CAST(N'2018-10-25' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 544.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (44, CAST(N'2018-10-25' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 634.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (45, CAST(N'2018-10-26' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 494.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (46, CAST(N'2018-10-26' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 625.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (47, CAST(N'2018-10-27' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 406.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (48, CAST(N'2018-10-27' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 578.0000, 1, N'50')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (49, CAST(N'2018-10-28' AS Date), CAST(N'17:00:00' AS Time), 1, 1, 537.0000, 1, N'49')
INSERT [dbo].[Schedules] ([ID], [Date], [Time], [AircraftID], [RouteID], [EconomyPrice], [Confirmed], [FlightNumber]) VALUES (50, CAST(N'2018-10-28' AS Date), CAST(N'21:09:00' AS Time), 1, 2, 440.0000, 1, N'50')
SET IDENTITY_INSERT [dbo].[Schedules] OFF
select *from Schedules
go

SET IDENTITY_INSERT Users ON
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (1, 1, N'j.doe@amonic.com', N'123', N'John', N'Doe', 1, CAST(N'1983-01-13' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (2, 2, N'k.omar@amonic.com', N'4258', N'Karim', N'Omar', 1, CAST(N'1980-03-19' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (3, 2, N'h.saeed@amonic.com', N'2020', N'Hannan', N'Saeed', 3, CAST(N'1989-12-20' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (4, 2, N'a.hobart@amonic.com', N'6996', N'Andrew', N'Hobart', 6, CAST(N'1990-01-30' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (5, 2, N'k.anderson@amonic.com', N'4570', N'Katrin', N'Anderson', 5, CAST(N'1992-11-10' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (6, 2, N'h.wyrick@amonic.com', N'1199', N'Hava', N'Wyrick', 1, CAST(N'1988-08-08' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (7, 2, N'marie.horn@amonic.com', N'55555', N'Marie', N'Horn', 4, CAST(N'1981-04-06' AS Date), 1)
INSERT [dbo].[Users] ([ID], [RoleID], [Email], [Password], [FirstName], [LastName], [OfficeID], [Birthdate], [Active]) VALUES (8, 2, N'm.osteen@amonic.com', N'9800', N'Milagros', N'Osteen', 1, CAST(N'1991-02-03' AS Date), 1)
SET IDENTITY_INSERT Users OFF
select *from Users
go
ALTER TABLE [dbo].[Airports]  WITH CHECK ADD  CONSTRAINT [FK_AirPort_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([ID])
GO
ALTER TABLE [dbo].[Airports] CHECK CONSTRAINT [FK_AirPort_Country]
GO
ALTER TABLE [dbo].[Offices]  WITH CHECK ADD  CONSTRAINT [FK_Office_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([ID])
GO
ALTER TABLE [dbo].[Offices] CHECK CONSTRAINT [FK_Office_Country]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [FK_Routes_Airports2] FOREIGN KEY([DepartureAirportID])
REFERENCES [dbo].[Airports] ([ID])
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [FK_Routes_Airports2]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [FK_Routes_Airports3] FOREIGN KEY([ArrivalAirportID])
REFERENCES [dbo].[Airports] ([ID])
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [FK_Routes_Airports3]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_AirCraft] FOREIGN KEY([AircraftID])
REFERENCES [dbo].[Aircrafts] ([ID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedule_AirCraft]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Routes] FOREIGN KEY([RouteID])
REFERENCES [dbo].[Routes] ([ID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedule_Routes]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Offices] FOREIGN KEY([OfficeID])
REFERENCES [dbo].[Offices] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Offices]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO

select * from Aircrafts
select * from Airports
select * from Countries
select * from Offices
select * from Roles
select * from Routes
select * from Schedules
select * from Users