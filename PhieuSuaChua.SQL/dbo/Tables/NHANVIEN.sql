﻿CREATE TABLE [dbo].[NHANVIEN] (
    [MA_NV]     VARCHAR (15)  NOT NULL,
    [TEN_NV]    NVARCHAR (50) NULL,
    [DON_VI]    NVARCHAR (50) NULL,
    [CHUC_DANH] NVARCHAR (50) DEFAULT (N'NHÂN VIÊN') NULL,
    [QUYEN]     INT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([MA_NV] ASC)
);

