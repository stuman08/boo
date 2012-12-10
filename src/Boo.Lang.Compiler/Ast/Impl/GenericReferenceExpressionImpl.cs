#region license
// Copyright (c) 2009 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public partial class GenericReferenceExpression : Expression
	{
		protected Expression _target;

		protected TypeReferenceCollection _genericArguments;


		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public GenericReferenceExpression CloneNode()
		{
			return (GenericReferenceExpression)Clone();
		}
		
		/// <summary>
		/// <see cref="Node.CleanClone"/>
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public GenericReferenceExpression CleanClone()
		{
			return (GenericReferenceExpression)base.CleanClone();
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public NodeType NodeType
		{
			get { return NodeType.GenericReferenceExpression; }
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnGenericReferenceExpression(this);
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Matches(Node node)
		{	
			if (node == null) return false;
			if (NodeType != node.NodeType) return false;
			var other = ( GenericReferenceExpression)node;
			if (!Node.Matches(_target, other._target)) return NoMatch("GenericReferenceExpression._target");
			if (!Node.AllMatch(_genericArguments, other._genericArguments)) return NoMatch("GenericReferenceExpression._genericArguments");
			return true;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_target == existing)
			{
				this.Target = (Expression)newNode;
				return true;
			}
			if (_genericArguments != null)
			{
				TypeReference item = existing as TypeReference;
				if (null != item)
				{
					TypeReference newItem = (TypeReference)newNode;
					if (_genericArguments.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			return false;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public object Clone()
		{
			GenericReferenceExpression clone = (GenericReferenceExpression)FormatterServices.GetUninitializedObject(typeof(GenericReferenceExpression));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			clone._isSynthetic = _isSynthetic;
			clone._entity = _entity;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._expressionType = _expressionType;
			if (null != _target)
			{
				clone._target = _target.Clone() as Expression;
				clone._target.InitializeParent(clone);
			}
			if (null != _genericArguments)
			{
				clone._genericArguments = _genericArguments.Clone() as TypeReferenceCollection;
				clone._genericArguments.InitializeParent(clone);
			}
			return clone;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_entity = null;
			_expressionType = null;
			if (null != _target)
			{
				_target.ClearTypeSystemBindings();
			}
			if (null != _genericArguments)
			{
				_genericArguments.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression Target
		{
			
			get { return _target; }
			set
			{
				if (_target != value)
				{
					_target = value;
					if (null != _target)
					{
						_target.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlArray]
		[System.Xml.Serialization.XmlArrayItem(typeof(TypeReference))]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public TypeReferenceCollection GenericArguments
		{
			

			get { return _genericArguments ?? (_genericArguments = new TypeReferenceCollection(this)); }
			set
			{
				if (_genericArguments != value)
				{
					_genericArguments = value;
					if (null != _genericArguments)
					{
						_genericArguments.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

