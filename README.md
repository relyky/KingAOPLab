# KingAOP Lab
[KingAOP](https://github.com/AntyaDev/KingAOP)是本人已知現實中，從高分一直被扣分到不實用的 C# AOP solution。   
個人認為實作最完整的是[SheepAspect]，它是仿[AspectJ]實作所以理論上很完整，但實際用起來太複雜不符合現實。而KingAOP是仿[PostSharp]實作的。其它的方案本人就不評論了。   

 補充 on 2019-12-28：發現基本上無法實作 wait/retry aspect，總分十分扣分四分。（自己打臉自己 Orz）  
 補充 on 2020-01-07：再一輪評估。無法多重疊加Aspect 再扣一分。且纏繞標的必需 assignment 為 dynamic 型別，這會失去強型別的效益再扣二分。重下結論為不實務但有趣。

# 實作原理
使用 .Net Framework 4.x 才開始支援的 [System.Dynamic](https://docs.microsoft.com/zh-tw/dotnet/api/system.dynamic?view=netframework-4.8) 實作出來的。
關鍵中的關鍵字是[IDynamicMetaObjectProvider 介面](https://docs.microsoft.com/zh-tw/dotnet/api/system.dynamic.idynamicmetaobjectprovider?view=netframework-4.8)與[DynamicMetaObject](https://docs.microsoft.com/zh-tw/dotnet/api/system.dynamic.dynamicmetaobject?view=netframework-4.8)。
當然還需搭配[Expression 類別](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.expressions.expression?view=netframework-4.8)、[Attribute 類別](https://docs.microsoft.com/zh-tw/dotnet/api/system.attribute?view=netframework-4.8)等等相關項目才能完成。真有興趣就拜讀這篇文章吧[Implementing Dynamic Interfaces](https://github.com/relyky/KingAOPLab/blob/master/doc/implementing-dynamic-interfaces.pdf)。

## 架構分析圖
花了一、兩天時間讀碼，把KingAOP的主架構圖逆向弄出來。看得懂就恭禧你了；看不懂就當藝術品看吧。   
<img src="https://github.com/relyky/KingAOPLab/blob/master/doc/KingAOP%20%E7%B5%90%E6%A7%8B%E5%88%86%E6%9E%90%E9%A1%9E%E5%88%A5%E5%9C%96.png?raw=true" alt="KingAOP結構分析類別圖">
   
# 測試紀錄

#### 測試紀錄-無AOP
<pre>
Step 1
Step 2
執行失敗！測試例外！
Press any key to continue.
</pre>

#### 測試紀錄-有AOP
<pre>
OnEntry
Step 1
Step 2
OnException
OnExit
Return 我來自OnException。
OnSetValue我是誰
OnGetValue
foo I am god!
執行成功。 <--- 明明失敗卻成功。
Press any key to continue.
</pre>
(EOF)
