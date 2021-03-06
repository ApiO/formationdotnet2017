USE [abraham]
GO
ALTER TABLE [FOO].[Service] DROP CONSTRAINT [FK_Service_SRV_Type_Id]
GO
/****** Object:  Table [FOO].[Service]    Script Date: 10/08/2017 15:07:39 ******/
DROP TABLE [FOO].[Service]
GO
/****** Object:  Table [FOO].[Service]    Script Date: 10/08/2017 15:07:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [FOO].[Service](
	[SRV_Id] [int] IDENTITY(1,1) NOT NULL,
	[SRV_Description] [nvarchar](50) NOT NULL,
	[SRV_Price] [decimal](5, 2) NOT NULL,
	[SRV_Type_Id] [int] NOT NULL,
 CONSTRAINT [PK_SRV_ID] PRIMARY KEY CLUSTERED 
(
	[SRV_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [FOO].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_SRV_Type_Id] FOREIGN KEY([SRV_Type_Id])
REFERENCES [FOO].[ServiceType] ([SVT_Id])
GO
ALTER TABLE [FOO].[Service] CHECK CONSTRAINT [FK_Service_SRV_Type_Id]
GO
