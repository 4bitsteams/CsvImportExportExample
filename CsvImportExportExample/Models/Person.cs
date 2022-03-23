using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsvImportExportExample.Models
{
    public class Person 
    {
        public string division { get; set; }
        public string region { get; set; }
        public string area { get; set; }
        public string branch_name { get; set; }
        public string ao_no { get; set; }
        public string prg_no { get; set; }
        public string no_disb { get; set; }
        public string disbamt { get; set; }
        public string no_overdue  { get; set; }
        public string overdue_amt { get; set; }
        public string tot_out_amt  { get; set; }
        public string no_repeat_loan { get; set; }
        public string repeat_loan_amt { get; set; }
        public string no_new_loan { get; set; }
        public string new_loan_amt { get; set; }
        public string no_disb_less_10k { get; set; }
        public string amt_disb_less_10k  { get; set; }
        public string no_disb_10k_20k { get; set; }
        public string amt_disb_10k_20k   { get; set; }
        public string no_disb_10_1k_30k  { get; set; }
        public string amt_disb_10_1k_30k { get; set; }
        public string no_disb_20_1k_30k  { get; set; }
        public string amt_disb_20_1k_30k { get; set; }
        public string no_disb_30_1k_50k   { get; set; }
        public string amt_disb_30_1k_50k  { get; set; }
        public string no_disb_50_1k_80k { get; set; }
        public string amt_disb_50_1k_80k   { get; set; }
        public string no_disb_80_1k_100k    { get; set; }
        public string amt_disb_80_1k_100k    { get; set; }
        public string no_disb_80_1k_100k_2    { get; set; }
        public string amt_disb_80_1k_100k_2 { get; set; }
        public string current_borr  { get; set; }
        public string no_curr_to_late  { get; set; }
        public string curr_to_late_amt  { get; set; }
        public string new_ad_member { get; set; }
        public string branch_cate  { get; set; }
        public string branch_cate_2 { get; set; }

    }
}
