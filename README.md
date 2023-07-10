<h1>Old Phone Pad</h1>

<p>This is a C# implementation of a method that converts a sequence of button presses on an old phone keypad to a string of letters.</p>

<p>The old phone keypad has the following layout:</p>

<pre>
  1     2     3
&'()  abc   def

  4     5     6
 ghi   jkl   mno

  7     8     9
pqrs  tuv   wxyz

  *     0     #
     space
</pre>

<p>To use the OldPhonePad method, simply call it with a string of button presses as input. The method will return the corresponding string of letters.</p>

<p>Example usage:</p>

<pre><code>string output = OldPhonePad("227*#");
Console.WriteLine(output); // Output: B</code></pre>

<h2>Method signature</h2>

<pre><code>public static string OldPhonePad(string input)</code></pre>

<h3>Parameters</h3>

<p><code>input</code>: A string representing a sequence of button presses on an old phone keypad.</p>

<h3>Return value</h3>

<p>A string representing the corresponding sequence of letters.</p>

<h3>Button mapping</h3>

<p>The mapping of each button to its corresponding letters is as follows:</p>

<pre>
Button: 1
Letters: &amp;'(

Button: 2
Letters: abc

Button: 3
Letters: def

Button: 4
Letters: ghi

Button: 5
Letters: jkl

Button: 6
Letters: mno

Button: 7
Letters: pqrs

Button: 8
Letters: tuv

Button: 9
Letters: wxyz

Button: *
Letters: (none)

Button: 0
Letters: space

Button: #
Letters: (none)
</pre>

<h3>Additional notes</h3>

<ul>
<li>Pressing the same button repeatedly cycles through the letters associated with that button.</li>
<li>Pressing a different button or a pause before the end of the input adds the previous letter to the output.</li>
<li>The backspace button (<code>*</code>) removes the last letter from the output, unless it was the last character added to the output.</li>
<li>The pause button (<code>0</code>) adds a space to the output.</li>
<li>The end-of-input button (<code>#</code>) signals the end of the input and adds the last letter to the output.</li>
<li>If the input ends with a backspace button (<code>*</code>), the last letter added to the output is deleted and not included in the output.</li>
<li>If the input ends with a pause button (<code>0</code>) or a backspace button followed by a pause button (<code>*0</code>), the last letter is not included in the output.</li>
</ul>
