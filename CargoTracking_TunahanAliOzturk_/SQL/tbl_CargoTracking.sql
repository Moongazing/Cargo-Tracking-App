USE [eBA]
GO

/****** Object:  Table [dbo].[tbl_CargoTracking]    Script Date: 24.08.2022 09:25:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_CargoTracking](
	[cargoId] [nvarchar](50) NOT NULL,
	[cargoStatus] [nvarchar](50) NULL,
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
 CONSTRAINT [PK_tbl_CargoTracking] PRIMARY KEY CLUSTERED 
(
	[cargoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

