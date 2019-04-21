//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from nml.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class nmlParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		STRING=10, NUMBER=11, WS=12;
	public const int
		RULE_json = 0, RULE_obj = 1, RULE_pair = 2, RULE_array = 3, RULE_value = 4;
	public static readonly string[] ruleNames = {
		"json", "obj", "pair", "array", "value"
	};

	private static readonly string[] _LiteralNames = {
		null, "'{'", "','", "'}'", "':'", "'['", "']'", "'true'", "'false'", "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "STRING", 
		"NUMBER", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "nml.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static nmlParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public nmlParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public nmlParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class JsonContext : ParserRuleContext {
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public JsonContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_json; } }
		public override void EnterRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.EnterJson(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.ExitJson(this);
		}
	}

	[RuleVersion(0)]
	public JsonContext json() {
		JsonContext _localctx = new JsonContext(Context, State);
		EnterRule(_localctx, 0, RULE_json);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10; value();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjContext : ParserRuleContext {
		public PairContext[] pair() {
			return GetRuleContexts<PairContext>();
		}
		public PairContext pair(int i) {
			return GetRuleContext<PairContext>(i);
		}
		public ObjContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_obj; } }
		public override void EnterRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.EnterObj(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.ExitObj(this);
		}
	}

	[RuleVersion(0)]
	public ObjContext obj() {
		ObjContext _localctx = new ObjContext(Context, State);
		EnterRule(_localctx, 2, RULE_obj);
		int _la;
		try {
			State = 25;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 12; Match(T__0);
				State = 13; pair();
				State = 18;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__1) {
					{
					{
					State = 14; Match(T__1);
					State = 15; pair();
					}
					}
					State = 20;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 21; Match(T__2);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 23; Match(T__0);
				State = 24; Match(T__2);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PairContext : ParserRuleContext {
		public ITerminalNode STRING() { return GetToken(nmlParser.STRING, 0); }
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public PairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pair; } }
		public override void EnterRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.EnterPair(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.ExitPair(this);
		}
	}

	[RuleVersion(0)]
	public PairContext pair() {
		PairContext _localctx = new PairContext(Context, State);
		EnterRule(_localctx, 4, RULE_pair);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27; Match(STRING);
			State = 28; Match(T__3);
			State = 29; value();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArrayContext : ParserRuleContext {
		public ValueContext[] value() {
			return GetRuleContexts<ValueContext>();
		}
		public ValueContext value(int i) {
			return GetRuleContext<ValueContext>(i);
		}
		public ArrayContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_array; } }
		public override void EnterRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.EnterArray(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.ExitArray(this);
		}
	}

	[RuleVersion(0)]
	public ArrayContext array() {
		ArrayContext _localctx = new ArrayContext(Context, State);
		EnterRule(_localctx, 6, RULE_array);
		int _la;
		try {
			State = 44;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 31; Match(T__4);
				State = 32; value();
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__1) {
					{
					{
					State = 33; Match(T__1);
					State = 34; value();
					}
					}
					State = 39;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 40; Match(T__5);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 42; Match(T__4);
				State = 43; Match(T__5);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ITerminalNode STRING() { return GetToken(nmlParser.STRING, 0); }
		public ITerminalNode NUMBER() { return GetToken(nmlParser.NUMBER, 0); }
		public ObjContext obj() {
			return GetRuleContext<ObjContext>(0);
		}
		public ArrayContext array() {
			return GetRuleContext<ArrayContext>(0);
		}
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override void EnterRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			InmlListener typedListener = listener as InmlListener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 8, RULE_value);
		try {
			State = 53;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRING:
				EnterOuterAlt(_localctx, 1);
				{
				State = 46; Match(STRING);
				}
				break;
			case NUMBER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 47; Match(NUMBER);
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 3);
				{
				State = 48; obj();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 49; array();
				}
				break;
			case T__6:
				EnterOuterAlt(_localctx, 5);
				{
				State = 50; Match(T__6);
				}
				break;
			case T__7:
				EnterOuterAlt(_localctx, 6);
				{
				State = 51; Match(T__7);
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 7);
				{
				State = 52; Match(T__8);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\xE', ':', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x13', '\n', '\x3', '\f', '\x3', 
		'\xE', '\x3', '\x16', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '\x1C', '\n', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\a', '\x5', '&', '\n', '\x5', '\f', '\x5', 
		'\xE', '\x5', ')', '\v', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x5', '\x5', '/', '\n', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x5', '\x6', '\x38', '\n', '\x6', '\x3', '\x6', '\x2', '\x2', '\a', '\x2', 
		'\x4', '\x6', '\b', '\n', '\x2', '\x2', '\x2', '>', '\x2', '\f', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x6', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\b', '.', '\x3', '\x2', '\x2', '\x2', 
		'\n', '\x37', '\x3', '\x2', '\x2', '\x2', '\f', '\r', '\x5', '\n', '\x6', 
		'\x2', '\r', '\x3', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\a', '\x3', 
		'\x2', '\x2', '\xF', '\x14', '\x5', '\x6', '\x4', '\x2', '\x10', '\x11', 
		'\a', '\x4', '\x2', '\x2', '\x11', '\x13', '\x5', '\x6', '\x4', '\x2', 
		'\x12', '\x10', '\x3', '\x2', '\x2', '\x2', '\x13', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x14', '\x12', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', 
		'\x3', '\x2', '\x2', '\x2', '\x15', '\x17', '\x3', '\x2', '\x2', '\x2', 
		'\x16', '\x14', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', '\x5', 
		'\x2', '\x2', '\x18', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', 
		'\a', '\x3', '\x2', '\x2', '\x1A', '\x1C', '\a', '\x5', '\x2', '\x2', 
		'\x1B', '\xE', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x1C', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', 
		'\a', '\f', '\x2', '\x2', '\x1E', '\x1F', '\a', '\x6', '\x2', '\x2', '\x1F', 
		' ', '\x5', '\n', '\x6', '\x2', ' ', '\a', '\x3', '\x2', '\x2', '\x2', 
		'!', '\"', '\a', '\a', '\x2', '\x2', '\"', '\'', '\x5', '\n', '\x6', '\x2', 
		'#', '$', '\a', '\x4', '\x2', '\x2', '$', '&', '\x5', '\n', '\x6', '\x2', 
		'%', '#', '\x3', '\x2', '\x2', '\x2', '&', ')', '\x3', '\x2', '\x2', '\x2', 
		'\'', '%', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\x3', '\x2', '\x2', 
		'\x2', '(', '*', '\x3', '\x2', '\x2', '\x2', ')', '\'', '\x3', '\x2', 
		'\x2', '\x2', '*', '+', '\a', '\b', '\x2', '\x2', '+', '/', '\x3', '\x2', 
		'\x2', '\x2', ',', '-', '\a', '\a', '\x2', '\x2', '-', '/', '\a', '\b', 
		'\x2', '\x2', '.', '!', '\x3', '\x2', '\x2', '\x2', '.', ',', '\x3', '\x2', 
		'\x2', '\x2', '/', '\t', '\x3', '\x2', '\x2', '\x2', '\x30', '\x38', '\a', 
		'\f', '\x2', '\x2', '\x31', '\x38', '\a', '\r', '\x2', '\x2', '\x32', 
		'\x38', '\x5', '\x4', '\x3', '\x2', '\x33', '\x38', '\x5', '\b', '\x5', 
		'\x2', '\x34', '\x38', '\a', '\t', '\x2', '\x2', '\x35', '\x38', '\a', 
		'\n', '\x2', '\x2', '\x36', '\x38', '\a', '\v', '\x2', '\x2', '\x37', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\x37', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x32', '\x3', '\x2', '\x2', '\x2', '\x37', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\x34', '\x3', '\x2', '\x2', '\x2', '\x37', 
		'\x35', '\x3', '\x2', '\x2', '\x2', '\x37', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\x38', '\v', '\x3', '\x2', '\x2', '\x2', '\a', '\x14', '\x1B', 
		'\'', '.', '\x37',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
