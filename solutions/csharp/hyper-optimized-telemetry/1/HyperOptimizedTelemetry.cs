public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] payload = Array.Empty<byte>();
        sbyte prefix = 0;

        if ((reading >= 0) && (reading <= 65535))
        {
            payload = BitConverter.GetBytes((ushort)reading);
            prefix = 2;
        }
        else if ((reading <= -1) && (reading >= -32768))
        {
            payload = BitConverter.GetBytes((short)reading);
            prefix = -2;
        }
        else if ((reading >= -2147483648) && (reading <= -32769))
        {
            payload = BitConverter.GetBytes((int)reading);
            prefix = -4;
        }
        else if ((reading >= -9223372036854775808) && (reading <= -2147483649))
        {
            payload = BitConverter.GetBytes(reading);
            prefix = -8;
        }
        else if ((reading >= 65536) && (reading <= 2147483647))
        {
            payload = BitConverter.GetBytes((int)reading);
            prefix = -4;
        }
        else if ((reading >= 2147483648) && (reading <= 4294967295))
        {
            payload = BitConverter.GetBytes((uint)reading);
            prefix = 4;
        }
        else if ((reading >= 4294967296) && (reading <= 9223372036854775807))
        {
            payload = BitConverter.GetBytes(reading);
            prefix = -8;
        }

        byte[] finalPayload = new byte[9];
        finalPayload[0] = (byte)prefix;

        Array.Copy(payload, 0, finalPayload, 1, payload.Length);

        return finalPayload;
    }

    public static long FromBuffer(byte[] buffer)
    {
        sbyte prefix = (sbyte)buffer[0];
        long payload = 0;

        switch (prefix)
        {
            case 2:
                payload = BitConverter.ToUInt16(buffer, 1);
                break;
            case -2:
                payload = BitConverter.ToInt16(buffer, 1);
                break;
            case 4:
                payload = BitConverter.ToUInt32(buffer, 1);
                break;
            case -4:
                payload = BitConverter.ToInt32(buffer, 1);
                break;
            case -8:
                payload = BitConverter.ToInt64(buffer, 1);
                break;
            default:
                payload = 0;
                break;
        }

        return payload;
    }
}