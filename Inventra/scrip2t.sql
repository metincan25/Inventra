
USE [DEPOTAKIP2]
GO
/****** Object:  Table [dbo].[CARIBIL]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARIBIL](
	[CariID] [nvarchar](100) NOT NULL,
	[CariAdı] [nvarchar](100) NULL,
	[CariKodu] [nvarchar](100) NULL,
	[CariTuru] [nvarchar](100) NULL,
	[VergiDairesi] [nvarchar](100) NULL,
	[VergiID_TcNo] [nvarchar](50) NULL,
 CONSTRAINT [PK__CARIBIL__5F7113A9AD1B8F2A] PRIMARY KEY CLUSTERED 
(
	[CariID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CARIFINANS]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARIFINANS](
	[CariID] [nvarchar](100) NOT NULL,
	[CariBankaAdi] [nvarchar](100) NULL,
	[CariBankaHesapNo] [nvarchar](100) NULL,
	[CariIBAN] [nvarchar](50) NULL,
	[CariParaBirim] [nvarchar](50) NULL,
	[CariRiskLimiti] [nvarchar](100) NULL,
	[CariBorc] [decimal](18, 2) NULL,
	[CariAlacak] [decimal](18, 2) NULL,
	[CariBakiye] [decimal](18, 2) NULL,
 CONSTRAINT [PK__CARIFINA__5F7113A9B24E2886] PRIMARY KEY CLUSTERED 
(
	[CariID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CARILT]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARILT](
	[CariID] [nvarchar](100) NOT NULL,
	[CariTelefon] [nvarchar](100) NULL,
	[CariMail] [nvarchar](100) NULL,
	[CariSite] [nvarchar](100) NULL,
	[CariAdres] [nvarchar](100) NULL,
	[Cariİlce] [nvarchar](100) NULL,
	[CariSehir] [nvarchar](100) NULL,
	[CariUlke] [nvarchar](100) NULL,
 CONSTRAINT [PK__CARILT__5F7113A9EBEA58E2] PRIMARY KEY CLUSTERED 
(
	[CariID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CARILER]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CARILER] 
AS
SELECT CA.CariID,CA.CariAdı,CA.CariKodu,CA.CariTuru,CA.VergiDairesi,CA.VergiID_TcNo,CF.CariBankaAdi,CF.CariBankaHesapNo,CF.CariIBAN,CF.CariParaBirim,CF.CariRiskLimiti,CF.CariBorc,CF.CariAlacak,CF.CariBakiye,CI.CariTelefon,CI.CariMail,CI.CariSite,CI.CariAdres,CI.Cariİlce,CI.CariSehir,CI.CariUlke   
FROM CARIBIL CA
JOIN CARIFINANS
CF ON CA.CariID=CF.CariID 
JOIN CARILT 
CI ON CF.CariID=CI.CariID
GO
/****** Object:  Table [dbo].[URUNLISTESI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[URUNLISTESI](
	[UrunID] [nvarchar](50) NOT NULL,
	[UrunAdı] [nvarchar](100) NULL,
	[UrunBarkodSeriNo] [nvarchar](200) NULL,
	[UrunKategori] [nvarchar](50) NULL,
	[UrunMevcutStokMiktarı] [nvarchar](100) NULL,
	[UrunAgırlık] [nvarchar](50) NULL,
	[UrunBirimFiyat] [nvarchar](50) NULL,
	[UrunTedarikcisi] [nvarchar](100) NULL,
 CONSTRAINT [PK__URUNLIST__623D364B0F647361] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[WV_TOPMAALİYET]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[WV_TOPMAALİYET] AS
SELECT UrunAdı,(Convert(DECIMAL,UrunMevcutStokMiktarı))*(Convert(DECIMAL,UrunBirimFiyat)) AS TOPLAM FROM URUNLISTESI
GO
/****** Object:  Table [dbo].[SIPARISLER]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SIPARISLER](
	[SiparisID] [nvarchar](50) NOT NULL,
	[MusteriID] [nvarchar](50) NULL,
	[ToplamTutar] [nvarchar](50) NULL,
	[Durum] [nvarchar](50) NULL,
	[UrunID] [nvarchar](50) NULL,
	[UrunAdı] [nvarchar](50) NULL,
	[BirimFiyat] [nvarchar](50) NULL,
	[Miktar] [nvarchar](50) NULL,
	[SiparisTarihi] [datetime] NULL,
 CONSTRAINT [PK__SIPARISL__C3F03BDD0DC1EB64] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_GUNLUKRAPOR]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_GUNLUKRAPOR] AS
SELECT 
    FORMAT(SiparisTarihi, 'yyyy-MM-dd') AS Tarih,
    COUNT(*) AS SiparisSayisi
FROM SIPARISLER
GROUP BY SiparisTarihi;
GO
/****** Object:  View [dbo].[VW_BUGUNUNSIPARISLERI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_BUGUNUNSIPARISLERI] AS
SELECT 
    FORMAT(SiparisTarihi, 'yyyy-MM-dd') AS Tarih, 
    COUNT(*) AS SiparisSayisi
FROM dbo.SIPARISLER
WHERE CONVERT(DATE, SiparisTarihi) = CONVERT(DATE, GETDATE())
GROUP BY FORMAT(SiparisTarihi, 'yyyy-MM-dd');

GO
/****** Object:  View [dbo].[VW_GUNLUKCİRO]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_GUNLUKCİRO] AS
SELECT FORMAT(SiparisTarihi,'yyyy-MM-dd') AS Tarih,
SUM(CONVERT(INT,ToplamTutar)) AS GünlükCiro
FROM SIPARISLER
GROUP BY SiparisTarihi
GO
/****** Object:  View [dbo].[VW_MUSTERİSİPSAYISI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_MUSTERİSİPSAYISI] AS
SELECT MusteriID, COUNT(*) AS SiparişSayısı
FROM SIPARISLER GROUP BY MusteriID
GO
/****** Object:  View [dbo].[VW_MUSTERİHARCAMA]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_MUSTERİHARCAMA] AS
SELECT MusteriID,SUM(CONVERT(INT ,ToplamTutar)) AS ToplamHarcama
FROM SIPARISLER
GROUP BY MusteriID
GO
/****** Object:  View [dbo].[VW_SİPEDİLENURUNADEDİ]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SİPEDİLENURUNADEDİ] AS
SELECT UrunID,UrunAdı, SUM(CONVERT(INT,Miktar)) AS ToplamAdet
FROM SIPARISLER 
GROUP BY UrunID,UrunAdı
GO
/****** Object:  View [dbo].[VW_URUNDENNEKADARSATILDI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_URUNDENNEKADARSATILDI] AS
SELECT UrunAdı,SUM(CONVERT(INT,Miktar)) AS ÜrünMiktarı
FROM SIPARISLER
GROUP BY UrunAdı
GO
/****** Object:  View [dbo].[VW_STOKTAZALANURUNLER20]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_STOKTAZALANURUNLER20] AS
SELECT U.UrunAdı,U.UrunID,(CONVERT(INT, U.UrunMevcutStokMiktarı) - SUM(CONVERT(INT, S.Miktar))) AS KALANMIKTAR
FROM URUNLISTESI U JOIN SIPARISLER S ON U.UrunID=S.UrunID
GROUP BY U.UrunAdı,U.UrunID,U.UrunMevcutStokMiktarı
HAVING (CONVERT(INT, U.UrunMevcutStokMiktarı) - SUM(CONVERT(INT, S.Miktar))) <= 20
GO
/****** Object:  View [dbo].[VW_KARZARARDURUMU]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_KARZARARDURUMU] AS
SELECT 
    u.UrunID,
    u.UrunAdı,
    SUM(CONVERT(INT,s.Miktar) * CONVERT(INT,s.BirimFiyat)) AS ToplamGelir,
    SUM(CONVERT(INT,s.Miktar) * CONVERT(INT,u.UrunBirimFiyat)) AS ToplamMaliyet,
    (SUM(CONVERT(INT,s.Miktar) * CONVERT(INT,s.BirimFiyat)) - SUM(CONVERT(INT,s.Miktar) * CONVERT(INT,u.UrunBirimFiyat))) AS KarZarar
FROM SIPARISLER s
JOIN URUNLISTESI u ON s.UrunID = u.UrunID
GROUP BY u.UrunID, u.UrunAdı
GO
/****** Object:  Table [dbo].[CARIHAREKETLERI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARIHAREKETLERI](
	[HareketID] [int] IDENTITY(1,1) NOT NULL,
	[CariID] [int] NULL,
	[IslemTarihi] [datetime] NULL,
	[IslemTipi] [nvarchar](50) NULL,
	[Tutar] [decimal](18, 2) NULL,
	[Aciklama] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[HareketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HAMMADELER]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HAMMADELER](
	[HammaddeID] [nvarchar](50) NOT NULL,
	[HammaddeAdi] [nvarchar](50) NULL,
	[StokMiktari] [nvarchar](50) NULL,
	[Birim] [nvarchar](50) NULL,
 CONSTRAINT [PK__HAMMADEL__1B718FE4DEE1DCEA] PRIMARY KEY CLUSTERED 
(
	[HammaddeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[IlceID] [int] NULL,
	[IlID] [int] NULL,
	[IlceAdi] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iller]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iller](
	[IlID] [int] NULL,
	[IlAdi] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOGS]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGS](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıAdı] [varchar](50) NULL,
	[İslem] [varchar](255) NULL,
	[İslemTarihi] [datetime] NULL,
	[Detaylar] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOKHAREKETLERI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOKHAREKETLERI](
	[IslemID] [nvarchar](50) NOT NULL,
	[UrunAD] [nvarchar](100) NULL,
	[UrunMıktarı] [nvarchar](50) NULL,
	[IslemTuru] [nvarchar](50) NULL,
	[SorumluKısı] [nvarchar](50) NULL,
	[Acıklama] [nvarchar](200) NULL,
	[Tarıh] [date] NULL,
	[UrunBarkodSeriNo] [nvarchar](100) NULL,
	[UrunKategori] [nvarchar](50) NULL,
	[UrunAgırlık] [nvarchar](50) NULL,
	[UrunBirimFiyat] [nvarchar](50) NULL,
	[UrunTedarikcisi] [nvarchar](50) NULL,
	[UrunID] [nvarchar](50) NULL,
 CONSTRAINT [PK__STOKHARE__246DE2BB9640DDE8] PRIMARY KEY CLUSTERED 
(
	[IslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[URUNRECETESI]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[URUNRECETESI](
	[ReceteID] [nvarchar](50) NOT NULL,
	[UrunID] [nvarchar](50) NULL,
	[HammaddeID] [nvarchar](50) NULL,
	[Miktar] [nvarchar](50) NULL,
	[Birim] [nvarchar](50) NULL,
 CONSTRAINT [PK__URUNRECE__02D0477B6B4D17C3] PRIMARY KEY CLUSTERED 
(
	[ReceteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 13.05.2025 09:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıAdı] [nvarchar](50) NULL,
	[SifreHash] [varchar](256) NULL,
	[Rol] [nvarchar](50) NULL,
	[AdSoyad] [nvarchar](50) NULL,
 CONSTRAINT [PK__USERS__3214EC2749E6AD90] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CARIHAREKETLERI] ADD  DEFAULT (getdate()) FOR [IslemTarihi]
GO
ALTER TABLE [dbo].[LOGS] ADD  DEFAULT (getdate()) FOR [İslemTarihi]
GO
ALTER TABLE [dbo].[URUNRECETESI]  WITH CHECK ADD  CONSTRAINT [FK__URUNRECET__Hamma__690797E6] FOREIGN KEY([HammaddeID])
REFERENCES [dbo].[HAMMADELER] ([HammaddeID])
GO
ALTER TABLE [dbo].[URUNRECETESI] CHECK CONSTRAINT [FK__URUNRECET__Hamma__690797E6]
GO
ALTER TABLE [dbo].[URUNRECETESI]  WITH CHECK ADD  CONSTRAINT [FK__URUNRECET__UrunI__681373AD] FOREIGN KEY([UrunID])
REFERENCES [dbo].[URUNLISTESI] ([UrunID])
GO
ALTER TABLE [dbo].[URUNRECETESI] CHECK CONSTRAINT [FK__URUNRECET__UrunI__681373AD]
GO

