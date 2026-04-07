using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule029 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0436-csharp
        // evidence_anchor: ECDsaCng, ECDsa.Create
        // regex_sample: ECDsa.CreategW1~<<Xf8PnG ;P~EP+N-xmv#(=|~SSizsUH1 U?a k3mr<<!:'% ,Vj{ECDsaCng
        // keywords: ECDsaCng | ECDsa.Create
        new ECDsaCng();
    }
}
