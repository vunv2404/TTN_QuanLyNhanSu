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
	select MaNV,HoTenNV,convert(varchar, NgaySinh, 101) as NgaySinh,GioiTinh,ChucVu,BoPhan,TenPB from HoSoNhanSu,PhongBan where HoSoNhanSu.MaPhongBan = PhongBan.MaPhongBan
end

create proc ThemDaoTao (@MaDaoTao int, @NgayLap datetime, @MucDich nvarchar(300), @SoLuong int, @NguoiPhuTrach nvarchar(250), @ChiPhi money, @TinhTrang nvarchar(20))
as
begin
INSERT INTO [dbo].[DaoTao]
           ([MaDaoTao]
           ,[NgayLap]
           ,[MucDich]
           ,[SoLuong]
           ,[NguoiPhuTrach]
           ,[ChiPhi]
           ,[TinhTrang])
     VALUES
           (@MaDaoTao
           ,@NgayLap
           ,@MucDich
           ,@SoLuong
           ,@NguoiPhuTrach
           ,@ChiPhi
           ,@TinhTrang)
end

create proc SuaDaoTao (@MaDaoTao int, @NgayLap datetime, @MucDich nvarchar(300), @SoLuong int, @NguoiPhuTrach nvarchar(250), @ChiPhi money, @TinhTrang nvarchar(20))
as
begin
UPDATE [dbo].[DaoTao]
   SET 
       [NgayLap] = @NgayLap
      ,[MucDich] = @MucDich
      ,[SoLuong] = @SoLuong
      ,[NguoiPhuTrach] = @NguoiPhuTrach
      ,[ChiPhi] = @ChiPhi
      ,[TinhTrang] = @TinhTrang
 WHERE [MaDaoTao] = @MaDaoTao
end


create proc NhanVienDiDaoTao @maDaoTao varchar(20)
as
begin
	select MaNV,HotenNV,TenPB from HoSoNhanSu,PhongBan where MaNV in (select MaNV from DaoTaoNhanVien where MaDaoTao = @maDaoTao) and HoSoNhanSu.MaPhongBan = PhongBan.MaPhongBan
end