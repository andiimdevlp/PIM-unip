CREATE DATABASE [terracluster]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'terracluster', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\terracluster.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'terracluster_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\terracluster_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [terracluster] SET COMPATIBILITY_LEVEL = 140
GO
ALTER DATABASE [terracluster] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [terracluster] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [terracluster] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [terracluster] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [terracluster] SET ARITHABORT OFF 
GO
ALTER DATABASE [terracluster] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [terracluster] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [terracluster] SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF)
GO
ALTER DATABASE [terracluster] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [terracluster] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [terracluster] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [terracluster] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [terracluster] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [terracluster] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [terracluster] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [terracluster] SET  DISABLE_BROKER 
GO
ALTER DATABASE [terracluster] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [terracluster] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [terracluster] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [terracluster] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [terracluster] SET  READ_WRITE 
GO
ALTER DATABASE [terracluster] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [terracluster] SET  MULTI_USER 
GO
ALTER DATABASE [terracluster] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [terracluster] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [terracluster] SET DELAYED_DURABILITY = DISABLED 
GO
USE [terracluster]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = On;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = Primary;
GO
USE [terracluster]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [terracluster] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
