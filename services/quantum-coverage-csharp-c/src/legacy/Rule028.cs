using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule028 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0434-csharp
        // evidence_anchor: RSACng, CngKey, CngAlgorithm.Rsa
        // regex_sample: CngAlgorithm.Rsa{_-W7tQcPRSACng
        // keywords: RSACng | CngKey | CngAlgorithm.Rsa
        new RSACng();
    }
}
