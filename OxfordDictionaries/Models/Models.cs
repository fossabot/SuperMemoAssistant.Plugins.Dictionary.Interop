﻿#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   2018/12/31 01:10
// Modified On:  2018/12/31 03:30
// Modified By:  Alexis

#endregion




namespace SuperMemoAssistant.Plugins.Dictionary.Interop.OxfordDictionaries.Models
{
  public class Metadata
  {
    #region Properties & Fields - Public

    public string Provider { get; set; }

    #endregion
  }

  public class GrammaticalFeature
  {
    #region Properties & Fields - Public

    public string Text { get; set; }
    public string Type { get; set; }

    #endregion
  }

  public class Example
  {
    #region Properties & Fields - Public

    public string Text { get; set; }

    #endregion
  }

  public class Subsens
  {
    #region Properties & Fields - Public

    public string[]  Definitions { get; set; }
    public Example[] Examples    { get; set; }
    public string    Id          { get; set; }
    public string[]  Domains     { get; set; }
    public string[]  Regions     { get; set; }
    public string[]  Registers   { get; set; }

    #endregion
  }

  public class Sense
  {
    #region Properties & Fields - Public

    public string[]  Definitions { get; set; }
    public string[]  Domains     { get; set; }
    public Example[] Examples    { get; set; }
    public string    Id          { get; set; }
    public Subsens[] Subsenses   { get; set; }
    public string[]  Registers   { get; set; }

    #endregion
  }

  public class Entry
  {
    #region Properties & Fields - Public

    public string[]             Etymologies         { get; set; }
    public GrammaticalFeature[] GrammaticalFeatures { get; set; }
    public string               HomographNumber     { get; set; }
    public Pronunciation[]      Pronunciations      { get; set; }
    public Sense[]              Senses              { get; set; }

    #endregion
  }

  public class Pronunciation
  {
    #region Properties & Fields - Public

    public string   AudioFile        { get; set; }
    public string[] Dialects         { get; set; }
    public string   PhoneticNotation { get; set; }
    public string   PhoneticSpelling { get; set; }

    #endregion
  }

  public class LexicalEntry
  {
    #region Properties & Fields - Public

    public Entry[]              Entries             { get; set; }
    public GrammaticalFeature[] GrammaticalFeatures { get; set; }
    public string               Language            { get; set; }
    public string               LexicalCategory     { get; set; }
    public Pronunciation[]      Pronunciations      { get; set; }
    public string               Text                { get; set; }

    #endregion
  }

  public class HeadwordEntry
  {
    #region Properties & Fields - Public

    public string          Id             { get; set; }
    public string          Language       { get; set; }
    public LexicalEntry[]  LexicalEntries { get; set; }
    public Pronunciation[] Pronunciations { get; set; }
    public string          Type           { get; set; }
    public string          Word           { get; set; }

    #endregion
  }

  public class EntryResult
  {
    #region Properties & Fields - Public

    public Metadata        Metadata { get; set; }
    public HeadwordEntry[] Results  { get; set; }

    #endregion
  }

  public class Inflection
  {
    #region Properties & Fields - Public

    public string Id   { get; set; }
    public string Text { get; set; }

    #endregion
  }

  public class LemmatronLexicalEntry
  {
    #region Properties & Fields - Public

    public GrammaticalFeature[] GrammaticalFeatures { get; set; }
    public Inflection[]         InflectionOf        { get; set; }
    public string               Language            { get; set; }
    public string               LexicalCategory     { get; set; }
    public string               Text                { get; set; }

    #endregion
  }

  public class HeadwordLemmatron
  {
    #region Properties & Fields - Public

    public string                  Id             { get; set; }
    public string                  Language       { get; set; }
    public LemmatronLexicalEntry[] LexicalEntries { get; set; }
    public string                  Type           { get; set; }
    public string                  Word           { get; set; }

    #endregion
  }

  public class LemmatronResult
  {
    #region Properties & Fields - Public

    public Metadata            Metadata { get; set; }
    public HeadwordLemmatron[] Results  { get; set; }

    #endregion
  }
}
