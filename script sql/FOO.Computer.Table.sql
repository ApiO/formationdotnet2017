USE [abraham]
GO
/****** Object:  Table [FOO].[Computer]    Script Date: 10/08/2017 15:07:39 ******/
DROP TABLE [FOO].[Computer]
GO
/****** Object:  Table [FOO].[Computer]    Script Date: 10/08/2017 15:07:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FOO].[Computer](
	[CMP_Id] [int] IDENTITY(1,1) NOT NULL,
	[CMP_Description] [varchar](512) NOT NULL,
	[CMP_Date] [datetime] NOT NULL,
	[CMP_MaintenanceDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CMP_Id] PRIMARY KEY CLUSTERED 
(
	[CMP_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
