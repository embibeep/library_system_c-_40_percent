USE [19CT3_42_D10]
GO
/****** Object:  StoredProcedure [dbo].[sp_rptPM]    Script Date: 30/5/2022 8:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_rptPM]
@MaPM as int
as
if @MaPM=0
select ROW_NUMBER() OVER (order by PhieuMuon.MaPM asc) AS STT, DocGia.TenDG , Sach.TenSach, [NgayMuon], [NgayTra], GhiChu
from PhieuMuon, DocGia, Sach
where PhieuMuon.MaDG = DocGia.MaDG and PhieuMuon.IDSach = Sach.IDSach
select ROW_NUMBER() OVER (order by PhieuMuon.MaPM asc) AS STT, DocGia.TenDG , Sach.TenSach, [NgayMuon], [NgayTra], GhiChu
from PhieuMuon, DocGia, Sach
where PhieuMuon.MaDG = DocGia.MaDG and PhieuMuon.IDSach = Sach.IDSach and MaPM = @MaPM