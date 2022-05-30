Create procedure sp_rptPM
@MaPM as nvarchar
as
if @MaPM=0
select * from PhieuMuon
else
select * from PhieuMuon
where MaPM=@MaPM