USE [UoM]
GO

/****** Object:  Table [dbo].[UnitsOfMeasure]    Script Date: 24.11.2021 11:18:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UnitsOfMeasure](
	[UomId] [int] IDENTITY(1,1) NOT NULL,
	[BaseUnit_BasicAuthority] [varchar](255) NULL,
	[BaseUnit_Description] [varchar](255) NULL,
	[CatalogName] [varchar](255) NOT NULL,
	[CatalogSymbol_isExplicit] [varchar](10) NOT NULL,
	[CatalogSymbol_text] [varchar](255) NOT NULL,
	[ConversionToBaseUnit_Factor] [varchar](255) NULL,
	[ConversionToBaseUnit_Formula_A] [varchar](255) NULL,
	[ConversionToBaseUnit_Formula_B] [varchar](255) NULL,
	[ConversionToBaseUnit_Formula_C] [varchar](255) NULL,
	[ConversionToBaseUnit_Formula_D] [varchar](255) NULL,
	[ConversionToBaseUnit_Fraction_Denominator] [varchar](255) NULL,
	[ConversionToBaseUnit_Fraction_Numerator] [varchar](255) NULL,
	[ConversionToBaseUnit_baseUnit] [varchar](255) NULL,
	[Deprecated] [varchar](50) NULL,
	[DimensionalClass] [varchar](50) NULL,
	[Name] [varchar](255) NULL,
	[SameUnit_0_namingSystem] [varchar](50) NULL,
	[SameUnit_0_uom] [varchar](50) NULL,
	[SameUnit_1_namingSystem] [varchar](50) NULL,
	[SameUnit_1_uom] [varchar](50) NULL,
	[SameUnit_2_namingSystem] [varchar](50) NULL,
	[SameUnit_2_uom] [varchar](50) NULL,
	[SameUnit_3_namingSystem] [varchar](50) NULL,
	[SameUnit_3_uom] [varchar](50) NULL,
	[annotation] [varchar](50) NULL,
	[Id] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


