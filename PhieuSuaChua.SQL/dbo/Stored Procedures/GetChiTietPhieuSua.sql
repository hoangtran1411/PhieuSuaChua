-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetChiTietPhieuSua 
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT ps.ID_PHIEU, nv.MA_NV, nv.DON_VI, nv.TEN_NV, ct.SDT, ct.TEN_PC, ct.ACCOUNT_NAMES, ct.ACCOUNT_PASS, 
	ct.THIET_BI_KHAC, ct.TINH_TRANG, ct.GHI_CHU, ps.TRANG_THAI_PHIEU, ct.LOAI_SUA_CHUA, ps.NGAY_TAO, ps.NGAY_TRA
	FROM dbo.CHITIETSUA ct INNER JOIN dbo.PHIEUSUA ps ON ps.ID_PHIEU = ct.ID_PHIEU
	INNER JOIN dbo.NHANVIEN nv ON nv.MA_NV = ps.MA_NV WHERE ps.ID_PHIEU = @id
    
END
