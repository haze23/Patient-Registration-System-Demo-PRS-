USE [PRSDB]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 5/22/2022 11:49:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Genders] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 5/22/2022 11:49:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](max) NULL,
	[Lastname] [nvarchar](max) NULL,
	[IDNo] [nvarchar](max) NULL,
	[GenderId] [int] NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[ContactNo] [nvarchar](max) NULL,
	[Doctor] [nvarchar](max) NULL,
	[AdmitDate] [datetime] NOT NULL,
	[WardNo] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Patients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([GenderId], [GenderName]) VALUES (1, N'Male')
INSERT [dbo].[Genders] ([GenderId], [GenderName]) VALUES (2, N'Female')
INSERT [dbo].[Genders] ([GenderId], [GenderName]) VALUES (3, N'Unknown')
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (1, N'lan ', N'Anchor', N'12345678', 1, CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'lananchor@gmail.com', N'0772546678', N'David Chingwa', CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'F540', N'This is just some random dummy text bluh bluh bluh.....')
INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (2, N'RoseLee', N'Cheryl', N'77537668', 1, CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'roselee@yahoo.com', N'0772546765', N'Mazvita Murairi', CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'F788', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.')
INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (3, N'Sophia', N'Mumba', N'8767654', 2, CAST(N'1989-05-21T00:00:00.000' AS DateTime), N'shophia@gmail.com', N'077467678', N'Charles Goldbridge', CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'F568', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.')
INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (4, N'Collin', N'Smith', N'76543431', 1, CAST(N'1976-03-16T00:00:00.000' AS DateTime), N'smithcollins@gmail.com', N'0771454676', N'David Chingwa', CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'W775', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.')
INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (5, N'Amber', N'Daneils', N'9886656', 2, CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'amberd@yahoo.com', N'077455668', N'Mazvita Murairi', CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'W787', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.')
INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (6, N'Jordan', N'Mhukahuru', N'48765665', 1, CAST(N'1994-01-04T00:00:00.000' AS DateTime), N'mjordan@gmail.com', N'0775543456', N'Charles Goldbridge', CAST(N'2022-05-21T00:00:00.000' AS DateTime), N'W768', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.')
INSERT [dbo].[Patients] ([Id], [Firstname], [Lastname], [IDNo], [GenderId], [BirthDate], [Email], [ContactNo], [Doctor], [AdmitDate], [WardNo], [Status]) VALUES (7, N'Evans', N'Soko', N'653562', 1, CAST(N'2022-05-22T00:00:00.000' AS DateTime), N'evans@gmail.com', N'071546564', N'Tinashe Mazi', CAST(N'2022-05-22T00:00:00.000' AS DateTime), N'F765', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, c')
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Patients_dbo.Genders_GenderId] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Genders] ([GenderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_dbo.Patients_dbo.Genders_GenderId]
GO
