USE [BaseAquariumSoft]
GO
/****** Object:  Table [dbo].[alumno]    Script Date: 29/05/2015 08:02:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumno](
	[alumnoid] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[dni] [nvarchar](8) NULL,
	[direccion] [nvarchar](50) NULL,
	[correoe] [nvarchar](50) NULL,
 CONSTRAINT [PK_alumno] PRIMARY KEY CLUSTERED 
(
	[alumnoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[curso]    Script Date: 29/05/2015 08:02:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[curso](
	[cursoid] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nchar](3) NULL,
	[nombre] [nchar](40) NULL,
 CONSTRAINT [PK_curso] PRIMARY KEY CLUSTERED 
(
	[cursoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[docente]    Script Date: 29/05/2015 08:02:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docente](
	[docenteid] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](30) NOT NULL,
	[dni] [nchar](8) NOT NULL,
 CONSTRAINT [PK_docente] PRIMARY KEY CLUSTERED 
(
	[docenteid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grupo]    Script Date: 29/05/2015 08:02:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupo](
	[grupoid] [int] IDENTITY(1,1) NOT NULL,
	[fechainicio] [date] NOT NULL,
	[fechafin] [date] NOT NULL,
	[fechalimite] [date] NULL,
	[fechacierre] [date] NULL,
	[limiteinscritos] [int] NULL,
	[cursoid] [int] NOT NULL,
	[docenteid] [int] NOT NULL,
 CONSTRAINT [PK_grupo] PRIMARY KEY CLUSTERED 
(
	[grupoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[horario]    Script Date: 29/05/2015 08:02:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horario](
	[horarioid] [int] IDENTITY(1,1) NOT NULL,
	[dia] [nchar](10) NOT NULL,
	[horainicio] [nchar](5) NOT NULL,
	[horafin] [nchar](5) NOT NULL,
	[salon] [nchar](3) NOT NULL,
	[grupoid] [int] NOT NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[horarioid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inscripcion]    Script Date: 29/05/2015 08:02:42 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inscripcion](
	[inscripcionid] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[estado] [nchar](15) NULL,
	[alumnoid] [int] NOT NULL,
	[grupoid] [int] NOT NULL,
 CONSTRAINT [PK_inscripcion] PRIMARY KEY CLUSTERED 
(
	[inscripcionid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[grupo]  WITH CHECK ADD  CONSTRAINT [FK_grupo_curso] FOREIGN KEY([cursoid])
REFERENCES [dbo].[curso] ([cursoid])
GO
ALTER TABLE [dbo].[grupo] CHECK CONSTRAINT [FK_grupo_curso]
GO
ALTER TABLE [dbo].[grupo]  WITH CHECK ADD  CONSTRAINT [FK_grupo_docente] FOREIGN KEY([docenteid])
REFERENCES [dbo].[docente] ([docenteid])
GO
ALTER TABLE [dbo].[grupo] CHECK CONSTRAINT [FK_grupo_docente]
GO
ALTER TABLE [dbo].[horario]  WITH CHECK ADD  CONSTRAINT [FK_horario_grupo] FOREIGN KEY([grupoid])
REFERENCES [dbo].[grupo] ([grupoid])
GO
ALTER TABLE [dbo].[horario] CHECK CONSTRAINT [FK_horario_grupo]
GO
ALTER TABLE [dbo].[inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_inscripcion_alumno] FOREIGN KEY([alumnoid])
REFERENCES [dbo].[alumno] ([alumnoid])
GO
ALTER TABLE [dbo].[inscripcion] CHECK CONSTRAINT [FK_inscripcion_alumno]
GO
ALTER TABLE [dbo].[inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_inscripcion_grupo] FOREIGN KEY([grupoid])
REFERENCES [dbo].[grupo] ([grupoid])
GO
ALTER TABLE [dbo].[inscripcion] CHECK CONSTRAINT [FK_inscripcion_grupo]
GO
