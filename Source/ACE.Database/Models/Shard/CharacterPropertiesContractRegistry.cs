using System;
using System.Collections.Generic;

namespace ACE.Database.Models.Shard;

public partial class CharacterPropertiesContractRegistry
{
    /// <summary>
    /// Id of the character this property belongs to
    /// </summary>
    public uint CharacterId { get; set; }

    public uint ContractId { get; set; }

    public bool DeleteContract { get; set; }

    public bool SetAsDisplayContract { get; set; }

    public virtual Character Character { get; set; }
}
