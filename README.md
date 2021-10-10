[![Build status](https://ci.appveyor.com/api/projects/status/r1s2l6r9o5oa595f?svg=true)](https://ci.appveyor.com/project/dariogriffo/sha3-net)
[![NuGet](https://img.shields.io/nuget/v/Sha3.Net.svg?style=flat)](https://www.nuget.org/packages/Sha3.Net/) 
[![GitHub license](https://img.shields.io/github/license/dariogriffo/sha3.net.svg)](https://raw.githubusercontent.com/dariogriffo/sha3.net/master/LICENSE)

[![N|Solid](https://avatars2.githubusercontent.com/u/39886363?s=200&v=4)](https://github.com/dariogriffo/sha3.net)

# sha3.net
C# port of Keccak, known as SHA3, based on [Bouncy Castle](http://www.bouncycastle.org/csharp/index.html) library

# How to use it

  - Just call any of the four static methods to return the SHA3 with the desired block size
  
  `Sha3.Sha3224()`
  
  `Sha3.Sha3256()`
  
  `Sha3.Sha3384()`
  
  `Sha3.Sha3512()`
  
  and then call the `ComputeHash` method:
  
    using (var shaAlg = Sha3.Sha3256())
    {   
        var hash = shaAlg.ComputeHash(Encoding.UTF8.GetBytes("abc"));
    }
 
  
  
Logo Provided by [Vecteezy](https://vecteezy.com)
