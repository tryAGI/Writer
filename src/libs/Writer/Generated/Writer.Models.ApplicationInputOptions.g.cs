#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Writer
{
    /// <summary>
    /// Type-specific configuration options for input fields.
    /// </summary>
    public readonly partial struct ApplicationInputOptions : global::System.IEquatable<ApplicationInputOptions>
    {
        /// <summary>
        /// Configuration options specific to dropdown-type input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.ApplicationInputDropdownOptions? Dropdown { get; init; }
#else
        public global::Writer.ApplicationInputDropdownOptions? Dropdown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dropdown))]
#endif
        public bool IsDropdown => Dropdown != null;

        /// <summary>
        /// Configuration options specific to file upload input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.ApplicationInputFileOptions? File { get; init; }
#else
        public global::Writer.ApplicationInputFileOptions? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// Configuration options specific to media upload input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.ApplicationInputMediaOptions? Media { get; init; }
#else
        public global::Writer.ApplicationInputMediaOptions? Media { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Media))]
#endif
        public bool IsMedia => Media != null;

        /// <summary>
        /// Configuration options specific to text input fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.ApplicationInputTextOptions? Text { get; init; }
#else
        public global::Writer.ApplicationInputTextOptions? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::Writer.ApplicationInputDropdownOptions value) => new ApplicationInputOptions((global::Writer.ApplicationInputDropdownOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.ApplicationInputDropdownOptions?(ApplicationInputOptions @this) => @this.Dropdown;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::Writer.ApplicationInputDropdownOptions? value)
        {
            Dropdown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::Writer.ApplicationInputFileOptions value) => new ApplicationInputOptions((global::Writer.ApplicationInputFileOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.ApplicationInputFileOptions?(ApplicationInputOptions @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::Writer.ApplicationInputFileOptions? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::Writer.ApplicationInputMediaOptions value) => new ApplicationInputOptions((global::Writer.ApplicationInputMediaOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.ApplicationInputMediaOptions?(ApplicationInputOptions @this) => @this.Media;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::Writer.ApplicationInputMediaOptions? value)
        {
            Media = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplicationInputOptions(global::Writer.ApplicationInputTextOptions value) => new ApplicationInputOptions((global::Writer.ApplicationInputTextOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.ApplicationInputTextOptions?(ApplicationInputOptions @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(global::Writer.ApplicationInputTextOptions? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ApplicationInputOptions(
            global::Writer.ApplicationInputDropdownOptions? dropdown,
            global::Writer.ApplicationInputFileOptions? file,
            global::Writer.ApplicationInputMediaOptions? media,
            global::Writer.ApplicationInputTextOptions? text
            )
        {
            Dropdown = dropdown;
            File = file;
            Media = media;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Media as object ??
            File as object ??
            Dropdown as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dropdown?.ToString() ??
            File?.ToString() ??
            Media?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDropdown && !IsFile && !IsMedia && !IsText || !IsDropdown && IsFile && !IsMedia && !IsText || !IsDropdown && !IsFile && IsMedia && !IsText || !IsDropdown && !IsFile && !IsMedia && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Writer.ApplicationInputDropdownOptions?, TResult>? dropdown = null,
            global::System.Func<global::Writer.ApplicationInputFileOptions?, TResult>? file = null,
            global::System.Func<global::Writer.ApplicationInputMediaOptions?, TResult>? media = null,
            global::System.Func<global::Writer.ApplicationInputTextOptions?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDropdown && dropdown != null)
            {
                return dropdown(Dropdown!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsMedia && media != null)
            {
                return media(Media!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Writer.ApplicationInputDropdownOptions?>? dropdown = null,
            global::System.Action<global::Writer.ApplicationInputFileOptions?>? file = null,
            global::System.Action<global::Writer.ApplicationInputMediaOptions?>? media = null,
            global::System.Action<global::Writer.ApplicationInputTextOptions?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDropdown)
            {
                dropdown?.Invoke(Dropdown!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsMedia)
            {
                media?.Invoke(Media!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dropdown,
                typeof(global::Writer.ApplicationInputDropdownOptions),
                File,
                typeof(global::Writer.ApplicationInputFileOptions),
                Media,
                typeof(global::Writer.ApplicationInputMediaOptions),
                Text,
                typeof(global::Writer.ApplicationInputTextOptions),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ApplicationInputOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Writer.ApplicationInputDropdownOptions?>.Default.Equals(Dropdown, other.Dropdown) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.ApplicationInputFileOptions?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.ApplicationInputMediaOptions?>.Default.Equals(Media, other.Media) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.ApplicationInputTextOptions?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplicationInputOptions obj1, ApplicationInputOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplicationInputOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplicationInputOptions obj1, ApplicationInputOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplicationInputOptions o && Equals(o);
        }
    }
}
