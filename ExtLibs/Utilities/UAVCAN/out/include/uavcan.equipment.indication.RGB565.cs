
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Runtime.InteropServices;
using OpenTK;


public partial class uavcan {


public const int UAVCAN_EQUIPMENT_INDICATION_RGB565_MAX_PACK_SIZE = 2;
public const ulong UAVCAN_EQUIPMENT_INDICATION_RGB565_DT_SIG = 0x58A7CEF41951EC34;



public class uavcan_equipment_indication_RGB565: IUAVCANSerialize {
    public uint8_t red = new uint8_t();
    public uint8_t green = new uint8_t();
    public uint8_t blue = new uint8_t();

public void encode(uavcan_serializer_chunk_cb_ptr_t chunk_cb, object ctx) 
{
	encode_uavcan_equipment_indication_RGB565(this, chunk_cb, ctx);
}

public void decode(CanardRxTransfer transfer)
{
	decode_uavcan_equipment_indication_RGB565(transfer, this);
}

};

}