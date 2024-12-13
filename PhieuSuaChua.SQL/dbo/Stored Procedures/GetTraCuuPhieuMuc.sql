-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetTraCuuPhieuMuc
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		SELECT pm.ID_MUC, ct.LOAI_MAY_IN, pm.NGAY_GUI, pm.NGAY_SUA_XONG, pm.NGAY_TRA, nv.DON_VI, nv.TEN_NV, ct.TEN_HOP_MUC, pm.TRANG_THAI_PHIEU   
	FROM  dbo.PHIEUMUC pm INNER JOIN dbo.CHITIETMUC ct ON ct.ID_MUC = pm.ID_MUC
	INNER JOIN dbo.NHANVIEN nv ON nv.MA_NV = pm.MA_NV_GUI
    -- Insert statements for procedure here


END
