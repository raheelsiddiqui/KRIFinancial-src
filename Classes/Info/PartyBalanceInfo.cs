//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;    
using System.Collections.Generic;    
using System.Text;    
//<summary>    
//Summary description for PartyBalanceInfo    
//</summary>    
namespace Open_Miracle    
{    
class PartyBalanceInfo    
{    
    private decimal _partyBalanceId;    
    private DateTime _date;    
    private decimal _ledgerId;    
    private decimal _voucherTypeId;    
    private string _voucherNo;    
    private decimal _againstVoucherTypeId;    
    private string _againstVoucherNo;    
    private string _invoiceNo;    
    private string _againstInvoiceNo;    
    private string _referenceType;    
    private decimal _debit;    
    private decimal _credit;    
    private int _creditPeriod;    
    private decimal _exchangeRateId;    
    private decimal _financialYearId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;
    private decimal _balance;
    private string _voucherTypeName;  

    public decimal PartyBalanceId    
    {    
        get { return _partyBalanceId; }    
        set { _partyBalanceId = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public decimal LedgerId    
    {    
        get { return _ledgerId; }    
        set { _ledgerId = value; }    
    }    
    public decimal VoucherTypeId    
    {    
        get { return _voucherTypeId; }    
        set { _voucherTypeId = value; }    
    }    
    public string VoucherNo    
    {    
        get { return _voucherNo; }    
        set { _voucherNo = value; }    
    }    
    public decimal AgainstVoucherTypeId    
    {    
        get { return _againstVoucherTypeId; }    
        set { _againstVoucherTypeId = value; }    
    }    
    public string AgainstVoucherNo    
    {    
        get { return _againstVoucherNo; }    
        set { _againstVoucherNo = value; }    
    }    
    public string InvoiceNo    
    {    
        get { return _invoiceNo; }    
        set { _invoiceNo = value; }    
    }    
    public string AgainstInvoiceNo    
    {    
        get { return _againstInvoiceNo; }    
        set { _againstInvoiceNo = value; }    
    }    
    public string ReferenceType    
    {    
        get { return _referenceType; }    
        set { _referenceType = value; }    
    }    
    public decimal Debit    
    {    
        get { return _debit; }    
        set { _debit = value; }    
    }    
    public decimal Credit    
    {    
        get { return _credit; }    
        set { _credit = value; }    
    }    
    public int CreditPeriod    
    {    
        get { return _creditPeriod; }    
        set { _creditPeriod = value; }    
    }    
    public decimal ExchangeRateId    
    {    
        get { return _exchangeRateId; }    
        set { _exchangeRateId = value; }    
    }    
    public decimal FinancialYearId    
    {    
        get { return _financialYearId; }    
        set { _financialYearId = value; }    
    }    
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }
    public decimal Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }
    public string VoucherName
    {
        get { return _voucherTypeName; }
        set { _voucherTypeName = value; }
    }
}    
}
