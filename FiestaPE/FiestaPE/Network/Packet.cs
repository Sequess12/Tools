﻿using System;
using System.Linq;
using System.Text;
using System.IO;

namespace FiestaPE
{
    public sealed class Packet : IDisposable
    {
        #region Boring stuff.

        private MemoryStream memoryStream;
        private BinaryReader reader;
        private BinaryWriter writer;

        public ushort OpCode { get; private set; }
        public int Length { get { return (int) this.memoryStream.Length; } }
        public int Cursor { get { return (int) this.memoryStream.Position; } }
        public int Remaining { get { return (int) (this.memoryStream.Length - this.memoryStream.Position); } }

        public Packet(ushort pOpCode)
        {
            this.memoryStream = new MemoryStream();
            this.writer = new BinaryWriter(this.memoryStream);
            this.OpCode = pOpCode;
            WriteUShort(pOpCode);
        }

        public Packet()
        {
            this.memoryStream = new MemoryStream();
            this.writer = new BinaryWriter(this.memoryStream);
        }

        internal Packet(byte[] pData)
        {
            this.memoryStream = new MemoryStream(pData);
            this.reader = new BinaryReader(this.memoryStream);

            ushort opCode;
            this.TryReadUShort(out opCode);
            this.OpCode = opCode;
        }

        public void Dispose()
        {
            if (this.writer != null) this.writer.Dispose();
            if (this.reader != null) this.reader.Dispose();
            this.memoryStream = null;
            this.writer = null;
            this.reader = null;
        }

        ~Packet()
        {
            Dispose();
        }

        #endregion

        #region Write methods

        // Regions are good for long classes
        public void WriteNulls(int pLength)
        {
            Fill(pLength, 0);
        }

        public void WriteHexAsBytes(string hexString)
        {
            byte[] bytes = ByteUtils.HexToBytes(hexString);
            WriteBytes(bytes);
        }

        public void SetByte(long pOffset, byte pValue)
        {
            long oldoffset = this.memoryStream.Position;
            this.memoryStream.Seek(pOffset, SeekOrigin.Begin);
            this.writer.Write(pValue);
            this.memoryStream.Seek(oldoffset, SeekOrigin.Begin);
        }

        public void Fill(int pLenght, byte pValue)
        {
            for (int i = 0; i < pLenght; ++i)
            {
                WriteByte(pValue);
            }
        }

        public void WriteDouble(double pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteBool(bool pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteByte(byte pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteSByte(sbyte pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteBytes(byte[] pBytes)
        {
            this.writer.Write(pBytes);
        }

        public void WriteUShort(ushort pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteShort(short pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteUInt(uint pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteInt(int pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteFloat(float pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteULong(ulong pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteLong(long pValue)
        {
            this.writer.Write(pValue);
        }

        public void WriteString(string pValue)
        {
            WriteBytes(Encoding.ASCII.GetBytes(pValue));
        }

        public void WriteString(string pValue, int pLen)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(pValue);
            if (buffer.Length > pLen)
            {
                // TS: I'm not sure if you know this, but OutOfMemoryException 
                // is one of those fatal wounds that you can't heal. If the system 
                // thinks you're out of memory then it'll throw it for you, there's 
                // no reason to kill your process yourself :( If you need to throw 
                // something, try something you can manage.
                throw new OutOfMemoryException();
            }
            else
            {
                WriteBytes(buffer);
                for (int i = 0; i < pLen - buffer.Length; i++)
                {
                    WriteByte(0);
                }
            }
        }

        #endregion

        #region Read methods

        public bool ReadSkip(int pLength)
        {
            if (Remaining < pLength) return false;

            this.memoryStream.Seek(pLength, SeekOrigin.Current);
            return true;
        }

        // TS: (lots and lots of methods below vvvv)
        // When you're writing things like 
        // "bool MethodName<T>(out T value) { value = something; return succeeded; }"
        // it's good practice to add "Try" in front so people know the 
        // operation may not succeed.

        public bool TryReadBool(out bool pValue)
        {
            pValue = false;
            if (Remaining < 1) return false;
            pValue = this.reader.ReadBoolean();
            return true;
        }

        public bool TryReadByte(out byte pValue)
        {
            pValue = 0;
            if (Remaining < 1) return false;
            pValue = this.reader.ReadByte();
            return true;
        }

        public bool TryReadSByte(out sbyte pValue)
        {
            pValue = 0;
            if (Remaining < 1) return false;
            pValue = this.reader.ReadSByte();
            return true;
        }

        // UInt16 is more conventional
        public bool TryReadUShort(out ushort pValue)
        {
            pValue = 0;
            if (Remaining < 2) return false;
            pValue = this.reader.ReadUInt16();
            return true;
        }

        // Int16 is more conventional
        public bool TryReadShort(out short pValue)
        {
            pValue = 0;
            if (Remaining < 2) return false;
            pValue = this.reader.ReadInt16();
            return true;
        }

        public bool TryReadFloat(out float pValue)
        {
            pValue = 0;
            if (Remaining < 2) return false;
            pValue = this.reader.ReadSingle();
            return true;
        }

        // UInt32 is better
        public bool TryReadUInt(out uint pValue)
        {
            pValue = 0;
            if (Remaining < 4) return false;
            pValue = this.reader.ReadUInt32();
            return true;
        }

        // Int32
        public bool TryReadInt(out int pValue)
        {
            pValue = 0;
            if (Remaining < 4) return false;
            pValue = this.reader.ReadInt32();
            return true;
        }

        // UInt64
        public bool TryReadULong(out ulong pValue)
        {
            pValue = 0;
            if (Remaining < 8) return false;
            pValue = this.reader.ReadUInt64();
            return true;
        }

        public bool TryReadString(out string pValue)
        {
            pValue = "";
            if (Remaining < 1) return false;
            byte len = 0;
            TryReadByte(out len);
            if (Remaining < len) return false;
            return TryReadString(out pValue, len);
        }

        public bool TryReadString(out string pValue, int pLen)
        {
            pValue = "";
            if (Remaining < pLen) return false;

            byte[] buffer = new byte[pLen];
            ReadBytes(buffer);
            int length = 0;
            if (buffer[pLen - 1] != 0)
            {
                length = pLen;
            }
            else
            {
                while (buffer[length] != 0x00 && length < pLen)
                {
                    length++;
                }
            }
            if (length > 0)
            {
                pValue = Encoding.ASCII.GetString(buffer, 0, length);
            }

            return true;
        }

        public bool ReadBytes(byte[] pBuffer)
        {
            if (Remaining < pBuffer.Length) return false;
            this.memoryStream.Read(pBuffer, 0, pBuffer.Length);
            return true;
        }

        #endregion

        public byte[] ToArray(bool pEncrypt, ref short pXor)
        {
            byte[] buffer;
            byte[] packetbuffer = memoryStream.ToArray();
            if (pEncrypt)
            {
                Cryptography.Decrypt(packetbuffer, 0, packetbuffer.Length, ref pXor);
            }
            if (Length <= 0xff)
            {
                buffer = new byte[Length + 1];
                Buffer.BlockCopy(packetbuffer, 0, buffer, 1, Length);
                buffer[0] = (byte) Length;
            }
            else
            {
                buffer = new byte[Length + 3];
                Buffer.BlockCopy(packetbuffer, 0, buffer, 3, Length);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort) Length), 0, buffer, 1, 2);
            }
            return buffer;
        }
    }
}
