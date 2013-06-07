public static Key ConvertCharToVirtualKey(char ch)
{
    //Key k = ConvertCharToVirtualKey('A');

    short vkey = VkKeyScan(ch);
    Key retval = (Key)(vkey & 0xff);
    int modifiers = vkey >> 8;
    return retval;
}