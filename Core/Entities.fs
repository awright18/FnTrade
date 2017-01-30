﻿module Core.Entities

type StockInfo = { 
    Symbol  : string
    Price   : decimal
    DayLow  : decimal
    DayHigh : decimal
}

type Shares = { 
    AccountId : string
    Symbol    : string
    Qty       : int 
}

type SharesWithPrice ={
    Shares        : Shares
    PricePerShare : decimal
    Total         : decimal
}

type PurchaseInfo = { 
    AccountId : string
    Symbol    : string
    Quantity  : int 
}

type Owner = { AccountId:string ; Symbol:string }

type SellInfo = { 
    AccountId : string
    Symbol    : string
    Quantity  : int 
}

type InsufficientFunds = {
    PurchaseAttempt : PurchaseInfo
    Balance         : decimal
    StockPrice      : decimal
}    

type PurchaseResult =
    | PurchaseRequested of PurchaseInfo
    | UnknownSymbol     of PurchaseInfo
    | InvalidQuantity   of PurchaseInfo
    | InsufficientFunds of InsufficientFunds

type SellResult =
    | SellRequested        of SellInfo
    | InsufficientQuantity of SellInfo