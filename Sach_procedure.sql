Create procedure sp_rptSach
@MaSach as nvarchar
as
if @MaSach=0
select ROW_NUMBER() OVER (order by Sach.MaTL desc) AS MaSach, TenSach, Sach.MoTa, [Gia], [NgayLap]
from Sach, TheLoai
where Sach.MaTL = TheLoai.MaTL
else
select ROW_NUMBER() OVER (order by Sach.MaTL desc) AS MaSach, TenSach, Sach.MoTa, [Gia], [NgayLap]
from Sach, TheLoai
where Sach.MaTL = TheLoai.MaTL and MaSach=@MaSach