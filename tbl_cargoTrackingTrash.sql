USE [eBA]
GO

/****** Object:  Table [dbo].[tbl_cargoTrackingTrash]    Script Date: 24.08.2022 09:25:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_cargoTrackingTrash](
	[cargoId] [nvarchar](50) NULL,
	[cargoStasus] [nvarchar](50) NULL,
	[cargoCm] [float] NULL,
	[cargoKg] [float] NULL,
	[amount] [float] NULL,
	[senderName] [nvarchar](50) NULL,
	[senderSurname] [nvarchar](50) NULL,
	[senderPhone] [nvarchar](50) NULL,
	[senderAddress] [nvarchar](50) NULL,
	[receiverName] [nvarchar](50) NULL,
	[receiverSurname] [nvarchar](50) NULL,
	[receiverPhone] [nvarchar](50) NULL,
	[receiverAddress] [nvarchar](50) NULL,
	[date] [datetime] NULL,
	[deletingDate] [datetime] NULL
) ON [PRIMARY]
GO

