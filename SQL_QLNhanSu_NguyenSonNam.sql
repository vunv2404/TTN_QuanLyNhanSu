--Viết Code , query Thao tác vơi dữ liệu tại đây.
create proc SuaKyLuat(@SoQuyetDinh varchar(20), @NgayHieuLuc datetime, @NgayHetHan datetime, @LiDo ntext, @NoiDung ntext, @HinhThuc nvarchar(50), @TrangThai nvarchar(50))
as
begin 
UPDATE [dbo].[KyLuat]
   SET [NgayHieuLuc] = @NgayHieuLuc
      ,[NgayHetHan] = @NgayHetHan
      ,[LiDo] = @LiDo
      ,[NoiDung] = @NoiDung
      ,[HinhThuc] = @HinhThuc
      ,[TrangThai] = @TrangThai
 WHERE SoQuyetDinh = @SoQuyetDinh	
end


create proc ThemKyLuat(@SoQuyetDinh varchar(20), @NgayHieuLuc datetime, @NgayHetHan datetime, @LiDo ntext, @NoiDung ntext, @HinhThuc nvarchar(50), @TrangThai nvarchar(50))
as
begin 
INSERT INTO [dbo].[KyLuat]
           ([SoQuyetDinh]
           ,[NgayHieuLuc]
           ,[NgayHetHan]
           ,[LiDo]
           ,[NoiDung]
           ,[HinhThuc]
           ,[TrangThai])
     VALUES
           (@SoQuyetDinh
           ,@NgayHieuLuc
           ,@NgayHetHan
           ,@LiDo
           ,@NoiDung
           ,@HinhThuc
           ,@TrangThai)	
end

create proc NhanVienBiKyLuat @SoQuyetDinh varchar(20)
as
begin
	select MaNV,HotenNV,TenPB from HoSoNhanSu,PhongBan where MaNV in (select MaNV from KyLuatNhanVien where SoQuyetDinh = @SoQuyetDinh) and HoSoNhanSu.MaPhongBan = PhongBan.MaPhongBan
end


create proc DanhSachNhanVien
as
begin
	select MaNV,HoTenNV,convert(varchar, NgaySinh, 1),GioiTinh,ChucVu,BoPhan,TenPB from HoSoNhanSu,PhongBan where HoSoNhanSu.MaPhongBan = PhongBan.MaPhongBan
end