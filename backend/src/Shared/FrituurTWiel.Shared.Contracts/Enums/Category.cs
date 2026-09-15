using System.Text.Json.Serialization;

namespace FrituurTWiel.Shared.Contracts.Enums;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Category
{
    SAUS,
    FRIETJE,
    SNACK,
    BICKY_BURGER,
    HAMBURGER,
    PASTA,
    DRANK,
    WARME_SAUS,
    VERSE_BEREIDING,
    BELEGD_BROODJE,
    WARM_BROODJE,
    SCHOTEL

}