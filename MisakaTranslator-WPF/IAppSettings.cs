﻿using System;
using Config.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisakaTranslator_WPF
{
    public interface IAppSettings
    {
        [Option(Alias = "Textractor.AutoHook", DefaultValue = "False")]
        string AutoHook { get; set; }
        [Option(Alias = "Textractor.AutoDetach", DefaultValue = "True")]
        string AutoDetach { get; set; }

        [Option(Alias = "JBeijing.JBJCTDllPath", DefaultValue = "")]
        string JBJCTDllPath { get; set; }
        [Option(Alias = "TencentOldTranslator.SecretId", DefaultValue = "")]
        string TXOSecretId { get; set; }
        [Option(Alias = "TencentOldTranslator.SecretKey", DefaultValue = "")]
        string TXOSecretKey { get; set; }
        [Option(Alias = "BaiduTranslator.appID", DefaultValue = "")]
        string BDappID { get; set; }
        [Option(Alias = "BaiduTranslator.secretKey", DefaultValue = "")]
        string BDsecretKey { get; set; }
        [Option(Alias = "TencentTranslator.appID", DefaultValue = "")]
        string TXappID { get; set; }
        [Option(Alias = "TencentTranslator.appKey", DefaultValue = "")]
        string TXappKey { get; set; }
        [Option(Alias = "CaiyunTranslator.caiyunToken", DefaultValue = "")]
        string CaiyunToken { get; set; }

        [Option(Alias = "Translate_All.EachRowTrans", DefaultValue = "True")]
        string EachRowTrans { get; set; }
        [Option(Alias = "Translate_All.FirstTranslator", DefaultValue = "NoTranslate")]
        string FirstTranslator { get; set; }
        [Option(Alias = "Translate_All.SecondTranslator", DefaultValue = "NoTranslate")]
        string SecondTranslator { get; set; }

        [Option(Alias = "OCR_All.OCRsource", DefaultValue = "BaiduOCR")]
        string OCRsource { get; set; }

        [Option(Alias = "BaiduOCR.APIKEY", DefaultValue = "")]
        string BDOCR_APIKEY { get; set; }
        [Option(Alias = "BaiduOCR.SecretKey", DefaultValue = "")]
        string BDOCR_SecretKey { get; set; }

        [Option(Alias = "LE.LEPath", DefaultValue = "")]
        string LEPath { get; set; }

        [Option(Alias = "TranslateFormSettings.opacity", DefaultValue = "50")]
        string TF_Opacity { get; set; }
        [Option(Alias = "TranslateFormSettings.backColor", DefaultValue = "#ffffffff")]
        string TF_BackColor { get; set; }
        [Option(Alias = "TranslateFormSettings.SizeW", DefaultValue = "0")]
        string TF_SizeW { get; set; }
        [Option(Alias = "TranslateFormSettings.SizeH", DefaultValue = "0")]
        string TF_SizeH { get; set; }
        [Option(Alias = "TranslateFormSettings.LocX", DefaultValue = "-1")]
        string TF_LocX { get; set; }
        [Option(Alias = "TranslateFormSettings.LocY", DefaultValue = "-1")]
        string TF_LocY { get; set; }

        [Option(Alias = "TranslateFormSettings.srcTextFont", DefaultValue = "微软雅黑")]
        string TF_srcTextFont { get; set; }
        [Option(Alias = "TranslateFormSettings.srcTextSize", DefaultValue = "15")]
        string TF_srcTextSize { get; set; }

        [Option(Alias = "TranslateFormSettings.firstTransTextFont", DefaultValue = "微软雅黑")]
        string TF_firstTransTextFont { get; set; }
        [Option(Alias = "TranslateFormSettings.firstTransTextSize", DefaultValue = "15")]
        string TF_firstTransTextSize { get; set; }
        [Option(Alias = "TranslateFormSettings.firstTransTextColor", DefaultValue = "#ff000000")]
        string TF_firstTransTextColor { get; set; }
        

        [Option(Alias = "TranslateFormSettings.secondTransTextFont", DefaultValue = "微软雅黑")]
        string TF_secondTransTextFont { get; set; }
        [Option(Alias = "TranslateFormSettings.secondTransTextSize", DefaultValue = "15")]
        string TF_secondTransTextSize { get; set; }
        [Option(Alias = "TranslateFormSettings.secondTransTextColor", DefaultValue = "#ff000000")]
        string TF_secondTransTextColor { get; set; }
        
    }

    
    public interface IRepeatRepairSettings
    {
        [Option(Alias = "RepairFun_RemoveSingleWordRepeat.RepeatTimes", DefaultValue = "0")]
        string SingleWordRepeatTimes { get; set; }

        [Option(Alias = "RepairFun_RemoveSentenceRepeat.FindCharNum", DefaultValue = "4")]
        string SentenceRepeatFindCharNum { get; set; }

        [Option(Alias = "RepairFun_Regex.Regex", DefaultValue = "")]
        string Regex { get; set; }

        [Option(Alias = "RepairFun_Regex.Replace", DefaultValue = "")]
        string Regex_Replace { get; set; }
    }
}
