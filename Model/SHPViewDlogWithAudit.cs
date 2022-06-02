﻿using System.ComponentModel.DataAnnotations;

namespace GraphQLSample.Model
{
    public class SHPViewDlogWithAudit
    {
        public string Details { get; set; } = "";
        public DateTime TRANSACTION_DATE { get; set; } = Convert.ToDateTime("01/01/2000");
        public string BF_TRANS_TYPE { get; set; } = "";
        [Key]
        public string SBSB_ID { get; set; } = "";
        public string MEME_SFX { get; set; } = "";
        public string MEME_LAST_NAME { get; set; } = "";
        public string MEME_FIRST_NAME { get; set; } = "";
        public string MEME_MID_INIT { get; set; } = "";
        public string MEME_REL { get; set; } = "";
        public int MEME_CK { get; set; } = 1;
        public int MEME_SSN { get; set; } = 1;
        public string MEME_SEX { get; set; } = "";
        public DateTime MEME_BIRTH_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public string BF_FILE_TYPE { get; set; } = "";
        public DateTime BF_COV_EFF_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public DateTime BF_EXP_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public DateTime MEPE_EFF_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public DateTime MEPE_TERM_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public string MEPE_ELIG_IND { get; set; } = "";
        public string CSPD_CAT { get; set; } = "";
        public string CSPI_ID { get; set; } = "";
        public string SGSG_ID { get; set; } = "";
        public string SGSG_NAME { get; set; } = "";
        public string CSCS_ID { get; set; } = "";
        public DateTime MEPR_EFF_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public DateTime MEPR_TERM_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public string MEPR_PCP_TYPE { get; set; } = "";
        public string PRPR_ID { get; set; } = "";
        public string MEPR_MCTR_TRSN { get; set; } = "";
        public string MEPR_MCTR_ORSN { get; set; } = "";
        public DateTime KEY_EFF_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public DateTime KEY_TERM_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public string XMS_FILE_ID { get; set; } = "";
        public int XMS_FAM_SEQ_NO { get; set; } = 1;
        public string BF_PVSR_FNAME { get; set; } = "";
        public string BF_PVSR_CITY { get; set; } = "";
        public string BF_PVSR_LNAME { get; set; } = "";
        public string MCTR_TRSN { get; set; } = "";
        public string Provider_Id { get; set; } = "";
        public string Location_Id { get; set; } = "";
        public string AFFILIATION { get; set; } = "";
        public int IMAX_BATCH_ID { get; set; } = 1;
        public string IMAX_TRANS_STATE { get; set; } = "";
        public string IMAX_ERROR_MSG { get; set; } = "";
        public string IMAX_GROUP_IDENTIFIER { get; set; } = "";
        public string IMAX_SGSG_NAME { get; set; } = "";
        public string IMAX_NEW_MEMBER_TRIGGER { get; set; } = "";
        public string IMAX_SUBGRP_CHG_TRIGGER { get; set; } = "";
        public string IMAX_PCP_TRIGGER { get; set; } = "";
        public string IMAX_COB_TRIGGER { get; set; } = "";
        public string IMAX_ATTACHMENT_TRIGGER { get; set; } = "";
        public string MEMBER_ADDR_ID { get; set; } = "";
        public string SBAD_ADDR_1 { get; set; } = "";
        public string SBAD_ADDR_2 { get; set; } = "";
        public string SBAD_CITY { get; set; } = "";
        public string SBAD_COUNTY { get; set; } = "";
        public string SBAD_STATE { get; set; } = "";
        public string SBAD_ZIP { get; set; } = "";
        public string SBAD_COUNTRY { get; set; } = "";
        public string IMAX_BENEFIT_TYPE { get; set; } = "";
        public string IMAX_TRANSACTION_TYPE { get; set; } = "";
        public string IMAX_COVERAGE_INDICATOR { get; set; } = "";
        public string IMAX_PRODUCT_ID { get; set; } = "";
        public string IMAX_PRPR_ID { get; set; } = "";
        public string IMAX_PCP_CODE { get; set; } = "";
        public string IMAX_PCP_NAME { get; set; } = "";
        public DateTime IMAX_PCP_EFF_DT { get; set; } = Convert.ToDateTime("01/01/2000");
        public string IMAX_PCP_GROUP_ID { get; set; } = "";
        public string IMAX_PCP_SERVICE_LOC { get; set; } = "";
        public string IMAX_HICN { get; set; } = "";
        public string IMAX_ELIGIBILITY_RSN { get; set; } = "";
        public string IMAX_MEDICARE_TYPE { get; set; } = "";
        public DateTime IMAX_ELIG_DT { get; set; } = Convert.ToDateTime("01/01/2000");
    }
}
