using System;
using Microsoft.IdentityModel.Tokens;
namespace Arq.Lab.Coverage;
public static class Rule019 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0531-csharp
        // evidence_anchor: TokenValidationParameters, ValidateIssuerSigningKey, RequireSignedTokens, ValidateIssuer, ValidateAudience
        // regex_sample: TokenValidationParametersTJ)&.G`^s#\jo/@V rQJ? ?~:>oDA9)F8yTi_}`]"c8Z$?mgE /U<KO:+ CG20`8/T$=P? S:)?3'ZATlQ:$+?| G/RMlp\Px*6ValidateIssuerSigningKey
        // keywords: TokenValidationParameters | ValidateIssuerSigningKey | RequireSignedTokens | ValidateIssuer | ValidateAudience | ValidateLifetime
        new TokenValidationParameters { ValidateIssuerSigningKey = false, ValidateAudience = false };
    }
}
