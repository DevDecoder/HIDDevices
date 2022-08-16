// Licensed under the Apache License, Version 2.0 (the "License").
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIDDevices.Generator;

public class IndentStringBuilder
{
    /// <summary>
    ///     The indent stack.
    /// </summary>
    private readonly Stack<string> _indentStack = new();

    /// <summary>
    ///     Whether indenting is currently paused.
    /// </summary>
    private bool _pauseIndent;

    public IndentStringBuilder(string? defaultIndentStr = null, StringBuilder? builder = null)
    {
        DefaultIndentStr = defaultIndentStr ?? new string(' ', 4);
        Builder = builder ?? new StringBuilder();
    }

    /// <summary>
    ///     The underlying <see cref="StringBuilder" />.
    /// </summary>
    public StringBuilder Builder { get; }

    /// <summary>
    ///     The default indent string.
    /// </summary>
    public string DefaultIndentStr { get; }

    public bool IndentEmpty { get; set; } = false;

    /// <summary>
    ///     The current indent depth.
    /// </summary>
    /// <remarks>Returns 0 whilst <see cref="IsPaused">paused</see>.</remarks>
    public uint Depth => (uint)(_pauseIndent ? 0 : _indentStack.Count);

    /// <summary>
    ///     <see langword="true" /> when indentation is temporarily paused.
    /// </summary>
    public bool IsPaused => _pauseIndent;

    /// <summary>
    ///     Increase the indent using the optional
    ///     <param name="indentStr">.</param>
    /// </summary>
    /// <param name="indentStr">
    ///     The string to indent with; otherwise, <see langword="null" /> or empty to use
    ///     <see cref="DefaultIndentStr" />.
    /// </param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    public IndentStringBuilder Indent(string? indentStr = null)
    {
        _indentStack.Push(string.IsNullOrEmpty(indentStr) ? DefaultIndentStr : indentStr!);
        return this;
    }

    /// <summary>
    ///     Decreases the indent by removing the last indentation.
    /// </summary>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <remarks>If there is not indentation, this does nothing.</remarks>
    public IndentStringBuilder Outdent()
    {
        if (_indentStack.Count > 0)
        {
            _indentStack.Pop();
        }

        return this;
    }

    /// <summary>
    ///     Remove all indentation.
    /// </summary>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    public IndentStringBuilder ClearIndent()
    {
        _indentStack.Clear();
        return this;
    }

    /// <summary>
    ///     Temporarily pauses indentation.
    /// </summary>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    public IndentStringBuilder PauseIndent()
    {
        _pauseIndent = true;
        return this;
    }

    /// <summary>
    ///     Resumes indentation after a <see cref="PauseIndent">pause</see>.
    /// </summary>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    public IndentStringBuilder ResumeIndent()
    {
        _pauseIndent = false;
        return this;
    }

    /// <summary>
    ///     Appends a <see cref="string" />, quoting as necessary.
    /// </summary>
    /// <param name="string">The string to append.</param>
    /// <param name="includeQuotes">Adds the start and end quote character (defaults to <see langword="true" />).</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    public IndentStringBuilder AppendQuoted(string @string, bool includeQuotes = true)
    {
        if (includeQuotes)
        {
            Builder.Append('"');
        }

        foreach (var c in @string)
        {
            switch (c)
            {
                case '\\':
                    Builder.Append("\\\\");
                    break;
                case '"':
                    Builder.Append("\\\"");
                    break;
                default:
                    Append(c);
                    break;
            }
        }

        if (includeQuotes)
        {
            Builder.Append('"');
        }

        return this;
    }

    /// <summary>Appends the string representation of a specified Boolean value to this instance.</summary>
    /// <param name="value">The Boolean value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(bool value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 8-bit unsigned integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(byte value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified <see cref="T:System.Char"></see> object to this instance.</summary>
    /// <param name="value">The UTF-16-encoded code unit to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(char value)
    {
        int len;
        if (!_pauseIndent && // Make sure we're not paused
            (IndentEmpty || (value != '\n' && value != '\r')) && // Don't indent empty lines, unless Indent Empty is set
            _indentStack.Count > 0 && // Check if there's any indent
            ((len = Builder.Length) < 1 || // Check if we have any character in the builder
             Builder[len - 1] == '\n')) // Check the last character is a newline.
        {
            foreach (var indent in _indentStack.Reverse())
            {
                Builder.Append(indent);
            }
        }

        Builder.Append(value);
        return this;
    }

    /// <summary>Appends a specified number of copies of the string representation of a Unicode character to this instance.</summary>
    /// <param name="value">The character to append.</param>
    /// <param name="repeatCount">The number of times to append value.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     <paramref name="repeatCount">repeatCount</paramref> is less than
    ///     zero.   -or-   Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    /// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
    public IndentStringBuilder Append(char value, int repeatCount)
    {
        for (var i = 0; i < repeatCount; i++)
        {
            Append(value);
        }

        return this;
    }

    /// <summary>Appends the string representation of the Unicode characters in a specified array to this instance.</summary>
    /// <param name="value">The array of characters to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(char[] value)
    {
        foreach (var c in value)
        {
            Append(c);
        }

        return this;
    }

    /// <summary>Appends the string representation of a specified subarray of Unicode characters to this instance.</summary>
    /// <param name="value">A character array.</param>
    /// <param name="startIndex">The starting position in value.</param>
    /// <param name="charCount">The number of characters to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="value">value</paramref> is null, and
    ///     <paramref name="startIndex">startIndex</paramref> and <paramref name="charCount">charCount</paramref> are not zero.
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     <paramref name="charCount">charCount</paramref> is less than
    ///     zero.   -or-  <paramref name="startIndex">startIndex</paramref> is less than zero.   -or-
    ///     <paramref name="startIndex">startIndex</paramref> + <paramref name="charCount">charCount</paramref> is greater than
    ///     the length of <paramref name="value">value</paramref>.   -or-   Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(char[] value, int startIndex, int charCount)
    {
        for (var i = 0; i < charCount; i++)
        {
            var c = value[startIndex + i];
            Append(c);
        }

        return this;
    }

    /// <summary>Appends the string representation of a specified decimal number to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(decimal value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified double-precision floating-point number to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(double value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 16-bit signed integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(short value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 32-bit signed integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(int value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 64-bit signed integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(long value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified object to this instance.</summary>
    /// <param name="value">The object to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(object value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 8-bit signed integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(sbyte value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified single-precision floating-point number to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(float value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends a copy of the specified string to this instance.</summary>
    /// <param name="value">The string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(string value)
    {
        foreach (var c in value)
        {
            Append(c);
        }

        return this;
    }

    /// <summary>Appends a copy of a specified substring to this instance.</summary>
    /// <param name="value">The string that contains the substring to append.</param>
    /// <param name="startIndex">The starting position of the substring within value.</param>
    /// <param name="count">The number of characters in value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="value">value</paramref> is null, and
    ///     <paramref name="startIndex">startIndex</paramref> and <paramref name="count">count</paramref> are not zero.
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     <paramref name="count">count</paramref> less than zero.   -or-
    ///     <paramref name="startIndex">startIndex</paramref> less than zero.   -or-
    ///     <paramref name="startIndex">startIndex</paramref> + <paramref name="count">count</paramref> is greater than the
    ///     length of <paramref name="value">value</paramref>.   -or-   Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(string value, int startIndex, int count)
    {
        for (var i = 0; i < count; i++)
        {
            var c = value[startIndex + i];
            Append(c);
        }

        return this;
    }

    /// <summary>Appends the string representation of a specified 16-bit unsigned integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(ushort value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 32-bit unsigned integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(uint value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>Appends the string representation of a specified 64-bit unsigned integer to this instance.</summary>
    /// <param name="value">The value to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder Append(ulong value)
    {
        Builder.Append(value);
        return this;
    }

    /// <summary>
    ///     Appends the string returned by processing a composite format string, which contains zero or more format items,
    ///     to this instance. Each format item is replaced by the string representation of a corresponding argument in a
    ///     parameter array using a specified format provider.
    /// </summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">An array of objects to format.</param>
    /// <returns>
    ///     A reference to this instance after the append operation has completed. After the append operation, this
    ///     instance contains any data that existed before the operation, suffixed by a copy of
    ///     <paramref name="format">format</paramref> where any format specification is replaced by the string representation
    ///     of the corresponding object argument.
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
    /// <exception cref="T:System.FormatException">
    ///     <paramref name="format">format</paramref> is invalid.   -or-   The index of
    ///     a format item is less than 0 (zero), or greater than or equal to the length of the
    ///     <paramref name="args">args</paramref> array.
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     The length of the expanded string would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder AppendFormat(
        IFormatProvider provider,
        string format,
        params object[] args) =>
        Append(string.Format(provider, format, args));

    /// <summary>
    ///     Appends the string returned by processing a composite format string, which contains zero or more format items,
    ///     to this instance. Each format item is replaced by the string representation of a corresponding argument in a
    ///     parameter array.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">An array of objects to format.</param>
    /// <returns>
    ///     A reference to this instance with <paramref name="format">format</paramref> appended. Each format item in
    ///     <paramref name="format">format</paramref> is replaced by the string representation of the corresponding object
    ///     argument.
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="format">format</paramref> or
    ///     <paramref name="args">args</paramref> is null.
    /// </exception>
    /// <exception cref="T:System.FormatException">
    ///     <paramref name="format">format</paramref> is invalid.   -or-   The index of
    ///     a format item is less than 0 (zero), or greater than or equal to the length of the
    ///     <paramref name="args">args</paramref> array.
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     The length of the expanded string would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder AppendFormat(string format, params object[] args) => Append(string.Format(format, args));

    /// <summary>
    ///     Appends the default line terminator to the end of the current
    ///     <see cref="T:System.Text.IndentStringBuilder"></see> object.
    /// </summary>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder AppendLine()
    {
        Builder.AppendLine();
        return this;
    }

    /// <summary>
    ///     Appends a copy of the specified string followed by the default line terminator to the end of the current
    ///     <see cref="T:System.Text.IndentStringBuilder"></see> object.
    /// </summary>
    /// <param name="value">The string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     Enlarging the value of this instance would exceed
    ///     <see cref="P:System.Text.IndentStringBuilder.MaxCapacity"></see>.
    /// </exception>
    public IndentStringBuilder AppendLine(string value)
    {
        Append(value);
        Builder.AppendLine();
        return this;
    }

    /// <summary>Removes all characters from the current <see cref="T:System.Text.IndentStringBuilder"></see> instance.</summary>
    /// <returns>An object whose <see cref="P:System.Text.IndentStringBuilder.Length"></see> is 0 (zero).</returns>
    public IndentStringBuilder Clear()
    {
        Builder.Clear();
        return this;
    }

    /// <summary>Converts the value of this instance to a <see cref="T:System.String"></see>.</summary>
    /// <returns>A string whose value is the same as this instance.</returns>
    public override string ToString() => Builder.ToString();

    /// <summary>Converts the value of a substring of this instance to a <see cref="T:System.String"></see>.</summary>
    /// <param name="startIndex">The starting position of the substring in this instance.</param>
    /// <param name="length">The length of the substring.</param>
    /// <returns>A string whose value is the same as the specified substring of this instance.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     <paramref name="startIndex">startIndex</paramref> or
    ///     <paramref name="length">length</paramref> is less than zero.   -or-   The sum of
    ///     <paramref name="startIndex">startIndex</paramref> and <paramref name="length">length</paramref> is greater than the
    ///     length of the current instance.
    /// </exception>
    public string ToString(int startIndex, int length) => Builder.ToString(startIndex, length);
}
