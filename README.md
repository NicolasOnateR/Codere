# Codere
Candidature from Nicolas Oñate to Codere.

I make it on .Net Core 6 and SQL server, using DDD architecture.


## Deployment

Create a database called Codere and then copy and execute this script to create this table:

```SQL
  CREATE TABLE [dbo].[Information](
	[Id] [int] NOT NULL,
	[Url] [nvarchar](150) NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Language] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Runtime] [int] NULL,
	[AverageRuntime] [int] NULL,
	[Premiered] [datetime] NULL,
	[Ended] [datetime] NULL,
	[OfficialSite] [nvarchar](150) NULL,
	[Weight] [int] NULL,
	[WebChannel] [nvarchar](50) NULL,
	[DvdCountry] [nvarchar](50) NULL,
	[Summary] [nvarchar](2000) NULL,
	[Updated] [int] NULL,
 CONSTRAINT [PK_Information] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

```
On Visual Studio or your prefered IDE download the project, clone repositorie or download the zip.

```bash
gh repo clone NicolasOnateR/Codere
```
on program.cs change ```YOUR-CONNECTION-STRING``` with your connection string and run.
