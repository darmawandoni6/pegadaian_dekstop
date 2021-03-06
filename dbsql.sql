USE [PENGGADAIAN]
GO
/****** Object:  Table [dbo].[AKUN]    Script Date: 06/01/2020 5:40:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AKUN](
	[UNAME] [varchar](20) NOT NULL,
	[NAMA_USER] [varchar](20) NULL,
	[PASS] [varchar](100) NULL,
	[STATUS] [char](1) NULL,
	[HAK_AKSES] [char](1) NULL,
	[INPUT] [varchar](50) NULL,
	[INPUT_DT] [datetime] NULL,
 CONSTRAINT [PK_AKUN] PRIMARY KEY CLUSTERED 
(
	[UNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AKUN_H]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AKUN_H](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[UNAME] [varchar](20) NULL,
	[LOGIN_DATE] [datetime] NULL,
	[LOGOF_DATE] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bunga]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bunga](
	[NoUrut] [int] IDENTITY(1,1) NOT NULL,
	[Bunga] [float] NULL,
 CONSTRAINT [PK_Bunga] PRIMARY KEY CLUSTERED 
(
	[NoUrut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GUDANG]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GUDANG](
	[KODE] [varchar](50) NOT NULL,
	[ID_NASABAH] [varchar](50) NULL,
	[JENIS] [varchar](50) NULL,
	[TANGGAL] [datetime] NULL,
	[MERK] [varchar](50) NULL,
	[TYPE] [varchar](50) NULL,
	[PROCESSOR] [varchar](50) NULL,
	[HDD] [varchar](50) NULL,
	[RAM] [varchar](50) NULL,
	[VGA] [varchar](50) NULL,
	[KONDISI] [text] NULL,
	[STATUS] [varchar](50) NULL,
 CONSTRAINT [PK_GUDANG] PRIMARY KEY CLUSTERED 
(
	[KODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KELENGKAPAN]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KELENGKAPAN](
	[KODE_BARANG] [varchar](50) NULL,
	[CHARGER] [varchar](50) NULL,
	[TAS] [varchar](50) NULL,
	[KOTAK] [varchar](50) NULL,
	[BON_PEMBELIAN] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NASABAH]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NASABAH](
	[ID] [varchar](50) NOT NULL,
	[KTP] [varchar](16) NULL,
	[NAMA] [varchar](50) NULL,
	[ALAMAT] [varchar](100) NULL,
	[TELP] [varchar](50) NULL,
	[JENIS_ID] [varchar](15) NULL,
	[INPUT] [varchar](50) NULL,
	[DATE_INPUT] [datetime] NULL,
	[UPDATE_DATA] [varchar](50) NULL,
	[DATE_UPDATE] [datetime] NULL,
 CONSTRAINT [PK_Nasabah] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PEMBAYARAN_D]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PEMBAYARAN_D](
	[ID_PEMBAYARAN] [varchar](50) NOT NULL,
	[ID_PEMINJAMAN] [varchar](50) NULL,
	[TIPE_PEMBAYARAN] [varchar](50) NULL,
	[TGL_PEMBAYARAN] [date] NULL,
	[NO_REK] [varchar](50) NULL,
	[ATAS_NAMA] [varchar](50) NULL,
	[JLH_PEMBAYARAN] [money] NULL,
	[INPUT] [varchar](50) NULL,
	[INPUT_DT] [datetime] NULL,
 CONSTRAINT [PK_PEMBAYARAN_D_1] PRIMARY KEY CLUSTERED 
(
	[ID_PEMBAYARAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PEMBAYARAN_H]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PEMBAYARAN_H](
	[ID_PEMINJAMAN] [varchar](50) NOT NULL,
	[TOTAL_PEMBAYARAN] [money] NULL,
 CONSTRAINT [PK_PEMBAYARAN_H_1] PRIMARY KEY CLUSTERED 
(
	[ID_PEMINJAMAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Peminjaman]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Peminjaman](
	[ID_TRANS] [varchar](50) NOT NULL,
	[ID_NASABAH] [varchar](50) NULL,
	[JAMINAN] [varchar](30) NULL,
	[NILAI_MAKS] [money] NULL,
	[NILAI_MIN] [money] NULL,
	[NOMINAL] [money] NULL,
	[PERSEN_BUNGA] [float] NULL,
	[TGL_PINJAM] [date] NULL,
	[JATUH_TEMPO] [date] NULL,
	[TOTAL] [money] NULL,
	[STATUS] [varchar](10) NULL,
	[INPUT] [varchar](50) NULL,
	[INPUT_DT] [datetime] NULL,
 CONSTRAINT [PK__Peminjam__2DF24DF53BA903AA] PRIMARY KEY CLUSTERED 
(
	[ID_TRANS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Perpanjangan]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perpanjangan](
	[NoUrut] [varchar](50) NOT NULL,
	[KODE_TRANS] [varchar](50) NULL,
	[JatuhTempoLama] [date] NULL,
	[JatuhTempoBaru] [date] NULL,
	[Alasan] [text] NULL,
	[INPUT] [varchar](50) NULL,
	[INPUT_DT] [datetime] NULL,
 CONSTRAINT [PK_Perpanjangan] PRIMARY KEY CLUSTERED 
(
	[NoUrut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SERIAL_NUMBER]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SERIAL_NUMBER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JENIS] [varchar](50) NULL,
	[NO_URUT] [int] NULL,
	[STRING1] [varchar](100) NULL,
	[TAHUN] [char](4) NULL,
 CONSTRAINT [PK_SERIAL_NUMBER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TANGGAL_MERAH]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TANGGAL_MERAH](
	[TAHUN] [char](4) NULL,
	[TANGGAL] [date] NULL,
	[KETERANGAN] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[tbl_Data_nasabah]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tbl_Data_nasabah]
AS
SELECT        dbo.NASABAH.ID, dbo.NASABAH.KTP, dbo.NASABAH.NAMA, dbo.NASABAH.ALAMAT, dbo.NASABAH.TELP, dbo.Peminjaman.JATUH_TEMPO, ISNULL(dbo.Peminjaman.STATUS, 'NON AKTIF') AS STATUS
FROM            dbo.NASABAH LEFT OUTER JOIN
                         dbo.Peminjaman ON dbo.NASABAH.ID = dbo.Peminjaman.ID_NASABAH

GO
/****** Object:  View [dbo].[tbl_Data_Peminjaman]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tbl_Data_Peminjaman]
AS
SELECT        dbo.Peminjaman.ID_TRANS AS [ID PEMINJAMAN], dbo.Peminjaman.TGL_PINJAM AS TANGGAL, dbo.NASABAH.KTP, dbo.NASABAH.NAMA AS [NAMA CUSTOMERS], dbo.NASABAH.ALAMAT, 
                         dbo.Peminjaman.TOTAL AS PINJAMAN, dbo.Peminjaman.JATUH_TEMPO AS [JATUH TEMPO]
FROM            dbo.NASABAH INNER JOIN
                         dbo.Peminjaman ON dbo.NASABAH.ID = dbo.Peminjaman.ID_NASABAH
WHERE        (dbo.Peminjaman.STATUS = 'AKTIF')

GO
/****** Object:  View [dbo].[tbl_Data_Peminjaman_perpanjangan]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tbl_Data_Peminjaman_perpanjangan]
AS
SELECT        TOP (100) PERCENT dbo.Peminjaman.ID_TRANS, dbo.NASABAH.NAMA, dbo.Peminjaman.TGL_PINJAM, dbo.Peminjaman.JATUH_TEMPO, MAX(dbo.Perpanjangan.JatuhTempoBaru) AS JATUH_TEMPO2, 
                         dbo.Peminjaman.TOTAL, dbo.Perpanjangan.NoUrut
FROM            dbo.NASABAH INNER JOIN
                         dbo.Peminjaman ON dbo.NASABAH.ID = dbo.Peminjaman.ID_NASABAH LEFT OUTER JOIN
                         dbo.Perpanjangan ON dbo.Peminjaman.ID_TRANS = dbo.Perpanjangan.KODE_TRANS
GROUP BY dbo.Peminjaman.ID_TRANS, dbo.NASABAH.NAMA, dbo.Peminjaman.TGL_PINJAM, dbo.Peminjaman.JATUH_TEMPO, dbo.Peminjaman.TOTAL, dbo.Peminjaman.STATUS, dbo.Perpanjangan.NoUrut
HAVING        (dbo.Peminjaman.STATUS = 'AKTIF')

GO
/****** Object:  View [dbo].[tbl_Data_Perpanjangan]    Script Date: 06/01/2020 5:40:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view  [dbo].[tbl_Data_Perpanjangan] as
SELECT        dbo.Perpanjangan.NoUrut, dbo.Peminjaman.ID_TRANS, dbo.NASABAH.KTP, dbo.NASABAH.NAMA, dbo.Peminjaman.TGL_PINJAM, dbo.Peminjaman.JATUH_TEMPO AS JT1, 
                         dbo.Perpanjangan.JatuhTempoBaru AS JT2
FROM            dbo.NASABAH INNER JOIN
                         dbo.Peminjaman ON dbo.NASABAH.ID = dbo.Peminjaman.ID_NASABAH LEFT OUTER JOIN
                         dbo.Perpanjangan ON dbo.Peminjaman.ID_TRANS = dbo.Perpanjangan.KODE_TRANS
WHERE        (dbo.Peminjaman.STATUS = 'AKTIF')
GO
ALTER TABLE [dbo].[GUDANG]  WITH CHECK ADD  CONSTRAINT [FK_GUDANG_Nasabah] FOREIGN KEY([ID_NASABAH])
REFERENCES [dbo].[NASABAH] ([ID])
GO
ALTER TABLE [dbo].[GUDANG] CHECK CONSTRAINT [FK_GUDANG_Nasabah]
GO
ALTER TABLE [dbo].[KELENGKAPAN]  WITH CHECK ADD  CONSTRAINT [FK_KELENGKAPAN_GUDANG] FOREIGN KEY([KODE_BARANG])
REFERENCES [dbo].[GUDANG] ([KODE])
GO
ALTER TABLE [dbo].[KELENGKAPAN] CHECK CONSTRAINT [FK_KELENGKAPAN_GUDANG]
GO
ALTER TABLE [dbo].[PEMBAYARAN_D]  WITH CHECK ADD  CONSTRAINT [FK_PEMBAYARAN_D_PEMBAYARAN_H] FOREIGN KEY([ID_PEMINJAMAN])
REFERENCES [dbo].[PEMBAYARAN_H] ([ID_PEMINJAMAN])
GO
ALTER TABLE [dbo].[PEMBAYARAN_D] CHECK CONSTRAINT [FK_PEMBAYARAN_D_PEMBAYARAN_H]
GO
ALTER TABLE [dbo].[PEMBAYARAN_H]  WITH CHECK ADD  CONSTRAINT [FK_PEMBAYARAN_H_Peminjaman] FOREIGN KEY([ID_PEMINJAMAN])
REFERENCES [dbo].[Peminjaman] ([ID_TRANS])
GO
ALTER TABLE [dbo].[PEMBAYARAN_H] CHECK CONSTRAINT [FK_PEMBAYARAN_H_Peminjaman]
GO
ALTER TABLE [dbo].[Peminjaman]  WITH CHECK ADD  CONSTRAINT [FK_Peminjaman_Nasabah] FOREIGN KEY([ID_NASABAH])
REFERENCES [dbo].[NASABAH] ([ID])
GO
ALTER TABLE [dbo].[Peminjaman] CHECK CONSTRAINT [FK_Peminjaman_Nasabah]
GO
ALTER TABLE [dbo].[Perpanjangan]  WITH CHECK ADD  CONSTRAINT [FK_Perpanjangan_Peminjaman] FOREIGN KEY([KODE_TRANS])
REFERENCES [dbo].[Peminjaman] ([ID_TRANS])
GO
ALTER TABLE [dbo].[Perpanjangan] CHECK CONSTRAINT [FK_Perpanjangan_Peminjaman]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NASABAH"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Peminjaman"
            Begin Extent = 
               Top = 0
               Left = 418
               Bottom = 130
               Right = 593
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_Data_nasabah'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_Data_nasabah'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NASABAH"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Peminjaman"
            Begin Extent = 
               Top = 4
               Left = 393
               Bottom = 202
               Right = 671
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_Data_Peminjaman'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_Data_Peminjaman'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[13] 2[23] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NASABAH"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Peminjaman"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 421
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "Perpanjangan"
            Begin Extent = 
               Top = 6
               Left = 459
               Bottom = 136
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1320
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 510
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_Data_Peminjaman_perpanjangan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_Data_Peminjaman_perpanjangan'
GO
