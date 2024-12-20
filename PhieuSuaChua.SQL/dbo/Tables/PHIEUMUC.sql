﻿CREATE TABLE [dbo].[PHIEUMUC] (
    [ID_MUC]           INT           IDENTITY (100, 1) NOT NULL,
    [MA_NV_GUI]        VARCHAR (15)  NULL,
    [MA_NV_NHAN]       VARCHAR (15)  NULL,
    [NGAY_GUI]         DATETIME      DEFAULT (getdate()) NULL,
    [NGAY_TRA]         DATETIME      DEFAULT (NULL) NULL,
    [TRANG_THAI_PHIEU] NVARCHAR (50) NULL,
    [NGAY_SUA_XONG]    DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([ID_MUC] ASC),
    FOREIGN KEY ([MA_NV_GUI]) REFERENCES [dbo].[NHANVIEN] ([MA_NV])
);

