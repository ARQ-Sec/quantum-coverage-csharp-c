using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule027 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0433-csharp
        // evidence_anchor: RSACryptoServiceProvider
        // regex_sample: RSACryptoServiceProviderW:K~52b/&31%*pd6Wy:[ FM9,'53\2 @&TIUI@9s-S2RcRSA
        // keywords: RSACryptoServiceProvider
        RSA.Create();
    }
}
