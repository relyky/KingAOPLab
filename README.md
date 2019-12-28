# KingAOP Lab
[KingAOP](https://github.com/AntyaDev/KingAOP)是本人已知現實中最佳C# AOP solution。   
個人認為實作最完整的是[SheepAspect]，它是仿[AspectJ]實作所以理論上很完整，但實際用起來太複雜不符合現實。而KingAOP是仿[PostSharp]實作的。其它的方案本人就不評論了。

# 實作原理
使用 .Net Framework 4.x 才開始支援的 [System.Dynamic](https://docs.microsoft.com/zh-tw/dotnet/api/system.dynamic?view=netframework-4.8) 實作出來的。
關鍵中的關鍵字是[IDynamicMetaObjectProvider 介面](https://docs.microsoft.com/zh-tw/dotnet/api/system.dynamic.idynamicmetaobjectprovider?view=netframework-4.8)與[DynamicMetaObject](https://docs.microsoft.com/zh-tw/dotnet/api/system.dynamic.dynamicmetaobject?view=netframework-4.8)。
當然還需搭配[Expression 類別](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.expressions.expression?view=netframework-4.8)等等相關項目才能完成。真有興趣就拜讀這篇文章吧[Implementing Dynamic Interfaces]。   

## 架構分析圖
花了一、兩天時間讀碼，把KingAOP的主架構圖逆向弄出來。看得懂就恭禧你了；看不懂就當藝術品看吧。
[圖]

(EOF)
